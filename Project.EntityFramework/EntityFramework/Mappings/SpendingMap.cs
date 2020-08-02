using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class SpendingMap : MultiTenantMap<Spending>
    {
        public SpendingMap()
        {
            //  FOREIGN KEYS
            HasMany(spending => spending.SpendingPayments)
              .WithRequired(spendingPayment => spendingPayment.Spending)
              .HasForeignKey(spendingPayment => spendingPayment.SpendingId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("spending");
        }
    }
}