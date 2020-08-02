using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class SpendingPaymentRepository : ProjectRepositoryBase<SpendingPayment>, ISpendingPaymentRepository
    {
        public SpendingPaymentRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}