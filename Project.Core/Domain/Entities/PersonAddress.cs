using Project.Domain.BaseEntity;

namespace Project.Domain.Entities
{
    public class PersonAddress : MultiTenantEntity
    {
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        public bool IsActive { get; set; }
    }
}