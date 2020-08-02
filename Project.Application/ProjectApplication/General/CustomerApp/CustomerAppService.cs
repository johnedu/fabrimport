using Abp.AutoMapper;
using Project.Domain;
using Project.Domain.Entities;
using Project.ProjectApplication.General.CustomerApp.DTOs.InputModels;
using Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels;
using Project.ProjectApplication.General.DTOs.InputModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.CustomerApp
{
    public class CustomerAppService : AppServiceBase, ICustomerAppService
    {
        #region Repositories
        private readonly ICustomerRepository _customerRepository;
        #endregion

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<GetAllCustomersOutput> GetAllCustomers()
        {
            List<Customer> customers = await _customerRepository.GetAllListAsync();

            return new GetAllCustomersOutput
            {
                Customers = customers.MapTo<List<CustomerOutput>>()
            };
        }

        public async Task<CustomerOutput> SaveCustomer(CustomerInput saveCustomer)
        {
            Customer customer;
            if (saveCustomer.Id.HasValue)
            {
                customer = await _customerRepository.GetAsync(saveCustomer.Id.Value);
                customer = saveCustomer.MapTo(customer);
                await _customerRepository.UpdateAsync(customer);
            }
            else
            {
                customer = saveCustomer.MapTo<Customer>();
                await _customerRepository.InsertAndGetIdAsync(customer);
            }

            return customer.MapTo<CustomerOutput>();
        }

        public async Task DeleteCustomer(IdInput customer)
        {
            await _customerRepository.DeleteAsync(customer.Id);
        }
    }
}
