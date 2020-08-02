using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class OrderProductRepository : ProjectRepositoryBase<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<OrderProduct>> GetAllByProduct(int productId)
        {
            return await GetAllListAsync(x => x.ProductId == productId);
        }

        public async Task DeleteByOrder(int orderId)
        {
            await DeleteAsync(x => x.OrderId == orderId);
        }
    }
}