using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class SaleInvoicePaymentMap : MultiTenantMap<SaleInvoicePayment>
    {
        public SaleInvoicePaymentMap()
        {
            //  TABLE NAME
            ToTable("sale_invoice_payment");
        }
    }
}