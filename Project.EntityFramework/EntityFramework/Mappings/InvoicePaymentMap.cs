using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class InvoicePaymentMap : MultiTenantMap<InvoicePayment>
    {
        public InvoicePaymentMap()
        {
            //  TABLE NAME
            ToTable("invoice_payment");
        }
    }
}