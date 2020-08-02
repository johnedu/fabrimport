using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class PhoneMap : MultiTenantMap<Phone>
    {
        public PhoneMap()
        {
            //  FOREIGN KEYS
            HasMany(phone => phone.CompanyPhones)
              .WithRequired(company => company.Phone)
              .HasForeignKey(company => company.PhoneId)
              .WillCascadeOnDelete(false);

            HasMany(phone => phone.PersonPhones)
              .WithRequired(person => person.Phone)
              .HasForeignKey(person => person.PhoneId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("phone");
        }
    }
}