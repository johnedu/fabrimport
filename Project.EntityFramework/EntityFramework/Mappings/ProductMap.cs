using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class ProductMap : MultiTenantMap<Product>
    {
        public ProductMap()
        {
            //  FOREIGN KEYS
            HasMany(product => product.InvoiceProducts)
              .WithRequired(invoiceProduct => invoiceProduct.Product)
              .HasForeignKey(invoiceProduct => invoiceProduct.ProductId)
              .WillCascadeOnDelete(false);

            HasMany(product => product.OrderProducts)
              .WithRequired(orderProduct => orderProduct.Product)
              .HasForeignKey(orderProduct => orderProduct.ProductId)
              .WillCascadeOnDelete(false);

            HasMany(product => product.SetProducts)
              .WithRequired(setProduct => setProduct.Product)
              .HasForeignKey(setProduct => setProduct.ProductId)
              .WillCascadeOnDelete(false);

            HasMany(product => product.ProductPrices)
              .WithRequired(productPrice => productPrice.Product)
              .HasForeignKey(productPrice => productPrice.ProductId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("product");
        }
    }
}