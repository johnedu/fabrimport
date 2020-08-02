using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class ProductCategoryMap : MultiTenantMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            //  FOREIGN KEYS
            HasMany(productCategory => productCategory.Products)
              .WithRequired(product => product.ProductCategory)
              .HasForeignKey(product => product.ProductCategoryId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("product_category");
        }
    }
}