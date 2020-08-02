using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class CustomerMap : MultiTenantMap<Customer>
    {
        public CustomerMap()
        {
            //  FOREIGN KEYS
            HasMany(customer => customer.Orders)
              .WithRequired(order => order.Customer)
              .HasForeignKey(order => order.CustomerId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("customer");
        }
    }
}