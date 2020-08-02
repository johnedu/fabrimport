using Abp.Application.Services;
using Project.ProjectApplication.General.CustomerApp.DTOs.InputModels;
using Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels;
using Project.ProjectApplication.General.DTOs.InputModels;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.CustomerApp
{
    public interface ICustomerAppService : IApplicationService
    {
        Task<GetAllCustomersOutput> GetAllCustomers();
        Task<CustomerOutput> SaveCustomer(CustomerInput saveCustomer);
        Task DeleteCustomer(IdInput customer);
    }
}