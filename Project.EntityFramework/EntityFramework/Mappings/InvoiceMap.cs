using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class InvoiceMap : MultiTenantMap<Invoice>
    {
        public InvoiceMap()
        {
            //  FOREIGN KEYS
            HasMany(invoice => invoice.InvoiceProducts)
              .WithRequired(invoiceProduct => invoiceProduct.Invoice)
              .HasForeignKey(invoiceProduct => invoiceProduct.InvoiceId)
              .WillCascadeOnDelete(false);

            HasMany(invoice => invoice.InvoicePayments)
              .WithRequired(invoicePayment => invoicePayment.Invoice)
              .HasForeignKey(invoicePayment => invoicePayment.InvoiceId)
              .WillCascadeOnDelete(false);

            HasMany(invoice => invoice.InvoiceSpendings)
              .WithOptional(spending => spending.Invoice)
              .HasForeignKey(spending => spending.InvoiceId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("invoice");
        }
    }
}