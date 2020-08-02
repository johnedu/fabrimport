using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class ProductRepository : ProjectRepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<Product> GetByName(string productName)
        {
            return await FirstOrDefaultAsync(x => string.Equals(x.Name, productName));
        }

        public async Task<List<Product>> GetAllByState(bool? isActive)
        {
            return await GetAllListAsync(x => !isActive.HasValue || x.IsActive == isActive.Value);
        }
    }
}