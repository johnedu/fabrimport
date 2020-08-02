using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class CountryMap : MultiTenantMap<Country>
    {
        public CountryMap()
        {
            //  FOREIGN KEYS
            HasMany(country => country.Departments)
              .WithRequired(department => department.Country)
              .HasForeignKey(department => department.CountryId)
              .WillCascadeOnDelete(false);

            HasMany(country => country.Phones)
             .WithOptional(phone => phone.Country)
             .HasForeignKey(phone => phone.CountryId)
             .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("country");
        }
    }
}