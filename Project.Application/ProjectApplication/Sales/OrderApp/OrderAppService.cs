using Abp.AutoMapper;
using Abp.Timing;
using Project.Domain;
using Project.Domain.Entities;
using Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels;
using Project.ProjectApplication.General.DTOs.InputModels;
using Project.ProjectApplication.General.EmployeeApp.DTOs.OutputModels;
using Project.ProjectApplication.General.PersonApp.DTOs.OutputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;
using Project.ProjectApplication.Sales.OrderApp.DTOs.InputModels;
using Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ProjectApplication.Sales.OrderApp
{
    public class OrderAppService : AppServiceBase, IOrderAppService
    {
        #region Repositories
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        private readonly IPersonRepository _personRepository;
        #endregion

        public OrderAppService(IOrderRepository orderRepository,
                               IOrderProductRepository orderProductRepository,
                               IEmployeeRepository employeeRepository,
                               ICustomerRepository customerRepository,
                               IProductRepository productRepository,
                               IPersonRepository personRepository)
        {
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
            _employeeRepository = employeeRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _personRepository = personRepository;
        }

        public async Task<GetAllOrdersOutput> GetAllOrders(GetAllOrdersInput filters)
        {
            List<Order> orders = await _orderRepository.GetAllByFilters(filters.EmployeeId, filters.CustomerId, filters.StateId, filters.StartDate, filters.EndDate);

            return new GetAllOrdersOutput
            {
                Orders = orders.MapTo<List<ListOrderOutput>>()
            };
        }

        public async Task<OrderOutput> GetOrder(IdInput orderId)
        {
            Order order = await _orderRepository.GetAsync(orderId.Id);

            return order.MapTo<OrderOutput>();
        }

        public async Task<GetInitialOrderDataOutput> GetInitialOrderData()
        {
            List<Employee> employees = await _employeeRepository.GetAllByState(true);
            List<Customer> customers = await _customerRepository.GetAllListAsync();
            List<Product> products = await _productRepository.GetAllByState(true);

            return new GetInitialOrderDataOutput {
                Employees = employees.MapTo<List<EmployeeOutput>>(),
                Customers = customers.MapTo<List<CustomerOutput>>(),
                Products = products.MapTo<List<BasicProductOutput>>()
            };
        }

        public async Task<GetCustomerPersonDataOutput> GetCustomerPersonData(IdInput person)
        {
            Person customerPerson = await _personRepository.GetAsync(person.Id);

            return new GetCustomerPersonDataOutput
            {
                CustomerPerson = customerPerson.MapTo<PersonOutput>()
            };
        }


        public async Task<SaveOrderOutput> SaveOrder(SaveOrderInput orderInfo)
        {
            Order order;
            if (orderInfo.Id.HasValue)
            {
                order = await _orderRepository.GetAsync(orderInfo.Id.Value);
                order = orderInfo.MapTo(order);
                await _orderRepository.UpdateAsync(order);
                foreach (OrderProductInput newOrderProduct in orderInfo.OrderProducts.Where(x => !x.Id.HasValue))
                {
                    OrderProduct orderProduct = newOrderProduct.MapTo<OrderProduct>();
                    await _orderProductRepository.InsertAsync(orderProduct);
                }
                foreach (OrderProduct deletedOrderProduct in order.Products.Where(x => orderInfo.OrderProducts.All(p => !p.Id.HasValue || p.Id.Value != x.Id)))
                {
                    await _orderProductRepository.DeleteAsync(deletedOrderProduct.Id);
                }
                foreach (OrderProductInput updatedOrderProduct in orderInfo.OrderProducts.Where(x => x.Id.HasValue && x.IsUpdatedRecord))
                {
                    OrderProduct orderProduct = await _orderProductRepository.GetAsync(updatedOrderProduct.Id.Value);
                    orderProduct = updatedOrderProduct.MapTo(orderProduct);
                    await _orderProductRepository.UpdateAsync(orderProduct);
                }
                await CurrentUnitOfWork.SaveChangesAsync();

                order = await _orderRepository.GetAsync(orderInfo.Id.Value);
            }
            else
            {
                order = orderInfo.MapTo<Order>();
                order.CreatedDate = Clock.Now;
                order.Products = orderInfo.OrderProducts.MapTo<List<OrderProduct>>();
                await _orderRepository.InsertAndGetIdAsync(order);
            }

            return new SaveOrderOutput { Order = order.MapTo<OrderOutput>() };
        }

        public async Task DeleteOrder(IdInput order)
        {
            await _orderRepository.DeleteAsync(order.Id);
        }
    }
}
