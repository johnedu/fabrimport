using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class SaleInvoicePaymentRepository : ProjectRepositoryBase<SaleInvoicePayment>, ISaleInvoicePaymentRepository
    {
        public SaleInvoicePaymentRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}