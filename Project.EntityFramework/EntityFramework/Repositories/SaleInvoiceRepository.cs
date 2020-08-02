using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class SaleInvoiceRepository : ProjectRepositoryBase<SaleInvoice>, ISaleInvoiceRepository
    {
        public SaleInvoiceRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}