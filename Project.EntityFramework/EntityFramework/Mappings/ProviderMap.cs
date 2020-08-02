using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class ProviderMap : MultiTenantMap<Provider>
    {
        public ProviderMap()
        {
            //  FOREIGN KEYS
            HasMany(provider => provider.Invoices)
              .WithRequired(invoice => invoice.Provider)
              .HasForeignKey(invoice => invoice.ProviderId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("provider");
        }
    }
}