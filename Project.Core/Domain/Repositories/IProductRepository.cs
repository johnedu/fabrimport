using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IProductRepository : IProjectRepositoryBase<Product>
    {
        Task<Product> GetByName(string productName);
        Task<List<Product>> GetAllByState(bool? isActive);
    }
}