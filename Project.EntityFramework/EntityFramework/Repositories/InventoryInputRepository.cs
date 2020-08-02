using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class InventoryInputRepository : ProjectRepositoryBase<InventoryInput>, IInventoryInputRepository
    {
        public InventoryInputRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}