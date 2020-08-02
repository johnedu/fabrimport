using Abp.Application.Services;
using Project.ProjectApplication.General.DTOs.InputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.InputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.ProductApp
{
    public interface IProductAppService : IApplicationService
    {
        Task<GetAllProductsOutput> GetAllProducts();
        Task<GetAllProductsOutput> GetAllActiveProducts();
        Task<ProductOutput> SaveProduct(ProductInput saveProduct);
        Task DeleteProduct(IdInput productId);
    }
}