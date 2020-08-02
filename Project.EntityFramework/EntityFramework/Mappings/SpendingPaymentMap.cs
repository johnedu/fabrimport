using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class SpendingPaymentMap : MultiTenantMap<SpendingPayment>
    {
        public SpendingPaymentMap()
        {
            //  TABLE NAME
            ToTable("spending_payment");
        }
    }
}