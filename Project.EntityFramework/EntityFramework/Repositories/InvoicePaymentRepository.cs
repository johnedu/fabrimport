using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class InvoicePaymentRepository : ProjectRepositoryBase<InvoicePayment>, IInvoicePaymentRepository
    {
        public InvoicePaymentRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}