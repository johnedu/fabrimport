using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class InvoiceProductRepository : ProjectRepositoryBase<InvoiceProduct>, IInvoiceProductRepository
    {
        public InvoiceProductRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<InvoiceProduct>> GetAllByProduct(int productId)
        {
            return await GetAllListAsync(x => x.ProductId == productId);
        }

        public async Task DeleteByInvoice(int invoiceId)
        {
            await DeleteAsync(x => x.InvoiceId == invoiceId);
        }
    }
}