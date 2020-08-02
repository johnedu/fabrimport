using Project.Domain;

namespace Project.ProjectApplication.Sales.InvoiceApp
{
    public class InvoiceAppService : AppServiceBase, IInvoiceAppService
    {
        #region Repositories
        private readonly IInvoiceRepository _invoiceRepository;
        #endregion

        public InvoiceAppService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
    }
}
