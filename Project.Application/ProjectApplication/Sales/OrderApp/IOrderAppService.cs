using Abp.Application.Services;
using Project.ProjectApplication.General.DTOs.InputModels;
using Project.ProjectApplication.Sales.OrderApp.DTOs.InputModels;
using Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels;
using System.Threading.Tasks;

namespace Project.ProjectApplication.Sales.OrderApp
{
    public interface IOrderAppService : IApplicationService
    {
        Task<GetAllOrdersOutput> GetAllOrders(GetAllOrdersInput filters);
        Task<GetInitialOrderDataOutput> GetInitialOrderData();
        Task<GetCustomerPersonDataOutput> GetCustomerPersonData(IdInput person);
        Task<OrderOutput> GetOrder(IdInput orderId);
        Task<SaveOrderOutput> SaveOrder(SaveOrderInput orderInfo);
        Task DeleteOrder(IdInput order);
    }
}