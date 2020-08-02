using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class InvoiceProductMap : MultiTenantMap<InvoiceProduct>
    {
        public InvoiceProductMap()
        {
            //  FOREIGN KEYS
            HasMany(invoiceProduct => invoiceProduct.InventoryInputs)
              .WithRequired(inventoryInput => inventoryInput.InvoiceProduct)
              .HasForeignKey(inventoryInput => inventoryInput.InvoiceProductId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("invoice_product");
        }
    }
}