using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class OrderMap : MultiTenantMap<Order>
    {
        public OrderMap()
        {
            //  FOREIGN KEYS
            HasMany(order => order.Products)
              .WithRequired(orderProduct => orderProduct.Order)
              .HasForeignKey(orderProduct => orderProduct.OrderId)
              .WillCascadeOnDelete(true);

            HasMany(order => order.Spendings)
              .WithOptional(spending => spending.Order)
              .HasForeignKey(spending => spending.OrderId)
              .WillCascadeOnDelete(false);

            HasMany(order => order.SaleInvoices)
              .WithRequired(spending => spending.Order)
              .HasForeignKey(spending => spending.OrderId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("order");
        }
    }
}