using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class PersonPhoneMap : MultiTenantMap<PersonPhone>
    {
        public PersonPhoneMap()
        {
            //  TABLE NAME
            ToTable("person_phone");
        }
    }
}