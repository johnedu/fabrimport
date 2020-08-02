using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class SaleInvoiceMap : MultiTenantMap<SaleInvoice>
    {
        public SaleInvoiceMap()
        {
            //  FOREIGN KEYS
            HasMany(saleInvoice => saleInvoice.Payments)
              .WithRequired(saleInvoicePayment => saleInvoicePayment.SaleInvoice)
              .HasForeignKey(saleInvoicePayment => saleInvoicePayment.SaleInvoiceId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("sale_invoice");
        }
    }
}