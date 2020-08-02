using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class PersonMap : MultiTenantMap<Person>
    {
        public PersonMap()
        {
            //  FOREIGN KEYS
            HasMany(person => person.Phones)
              .WithRequired(phone => phone.Person)
              .HasForeignKey(phone => phone.PersonId)
              .WillCascadeOnDelete(false);

            HasMany(person => person.Customers)
              .WithOptional(customer => customer.Person)
              .HasForeignKey(customer => customer.PersonId)
              .WillCascadeOnDelete(false);

            HasMany(person => person.Providers)
             .WithOptional(provider => provider.Person)
             .HasForeignKey(provider => provider.PersonId)
             .WillCascadeOnDelete(false);

            HasMany(person => person.Employees)
             .WithRequired(employee => employee.Person)
             .HasForeignKey(employee => employee.PersonId)
             .WillCascadeOnDelete(false);

            HasMany(person => person.PersonSpendings)
             .WithOptional(spending => spending.Person)
             .HasForeignKey(spending => spending.PersonId)
             .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("person");
        }
    }
}