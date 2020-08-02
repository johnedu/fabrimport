using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class ProductPriceMap : MultiTenantMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            //  TABLE NAME
            ToTable("product_price");
        }
    }
}