using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IInvoiceProductRepository : IProjectRepositoryBase<InvoiceProduct>
    {
        Task<List<InvoiceProduct>> GetAllByProduct(int productId);
        Task DeleteByInvoice(int invoiceId);
    }
}