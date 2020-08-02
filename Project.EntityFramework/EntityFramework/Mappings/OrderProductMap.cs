using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class OrderProductMap : MultiTenantMap<OrderProduct>
    {
        public OrderProductMap()
        {
            //  FOREIGN KEYS
            HasMany(orderProduct => orderProduct.InventoryOutputs)
              .WithRequired(inventoryOutput => inventoryOutput.OrderProduct)
              .HasForeignKey(inventoryOutput => inventoryOutput.OrderProductId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("order_product");
        }
    }
}