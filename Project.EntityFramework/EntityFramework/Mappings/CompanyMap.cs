using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class CompanyMap : MultiTenantMap<Company>
    {
        public CompanyMap()
        {
            //  FOREIGN KEYS
            HasMany(company => company.Phones)
              .WithRequired(phone => phone.Company)
              .HasForeignKey(phone => phone.CompanyId)
              .WillCascadeOnDelete(false);

            HasMany(company => company.Customers)
              .WithOptional(customer => customer.Company)
              .HasForeignKey(customer => customer.CompanyId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("company");
        }
    }
}