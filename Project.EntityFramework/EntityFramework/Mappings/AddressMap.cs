using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class AddressMap : MultiTenantMap<Address>
    {
        public AddressMap()
        {
            //  FOREIGN KEYS
            HasMany(address => address.Companies)
              .WithRequired(company => company.Address)
              .HasForeignKey(company => company.AddressId)
              .WillCascadeOnDelete(false);

            HasMany(address => address.PersonAddresses)
              .WithRequired(person => person.Address)
              .HasForeignKey(person => person.AddressId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("address");
        }
    }
}