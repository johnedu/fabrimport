using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IOrderProductRepository : IProjectRepositoryBase<OrderProduct>
    {
        Task<List<OrderProduct>> GetAllByProduct(int productId);
        Task DeleteByOrder(int orderId);
    }
}