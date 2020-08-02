using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class CityMap : MultiTenantMap<City>
    {
        public CityMap()
        {
            //  FOREIGN KEYS
            HasMany(city => city.Addresses)
              .WithRequired(address => address.City)
              .HasForeignKey(address => address.CityId)
              .WillCascadeOnDelete(false);

            HasMany(city => city.Phones)
              .WithOptional(phone => phone.City)
              .HasForeignKey(phone => phone.CityId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("city");
        }
    }
}