using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class SpendingRepository : ProjectRepositoryBase<Spending>, ISpendingRepository
    {
        public SpendingRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}