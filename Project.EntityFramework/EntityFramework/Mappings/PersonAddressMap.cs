using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class PersonAddressMap : MultiTenantMap<PersonAddress>
    {
        public PersonAddressMap()
        {
            //  TABLE NAME
            ToTable("person_address");
        }
    }
}