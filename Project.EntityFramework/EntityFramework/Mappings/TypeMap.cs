using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class TypeMap : MultiTenantMap<Type>
    {
        public TypeMap()
        {
            //  FOREIGN KEYS
            HasMany(type => type.PhoneTypes)
              .WithRequired(phone => phone.Type)
              .HasForeignKey(phone => phone.TypeId)
              .WillCascadeOnDelete(false);

            HasMany(type => type.CompanyDocumentTypes)
              .WithOptional(company => company.DocumentType)
              .HasForeignKey(company => company.DocumentTypeId)
              .WillCascadeOnDelete(false);

            HasMany(type => type.PersonDocumentTypes)
              .WithOptional(person => person.DocumentType)
              .HasForeignKey(person => person.DocumentTypeId)
              .WillCascadeOnDelete(false);

            HasMany(type => type.Spendings)
             .WithRequired(spending => spending.Type)
             .HasForeignKey(spending => spending.TypeId)
             .WillCascadeOnDelete(false);

            HasMany(type => type.States)
             .WithRequired(state => state.StateType)
             .HasForeignKey(state => state.StateTypeId)
             .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("type");
        }
    }
}