using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class InventoryOutputRepository : ProjectRepositoryBase<InventoryOutput>, IInventoryOutputRepository
    {
        public InventoryOutputRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}