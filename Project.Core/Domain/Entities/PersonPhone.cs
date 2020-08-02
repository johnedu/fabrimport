using Project.Domain.BaseEntity;

namespace Project.Domain.Entities
{
    public class PersonPhone : MultiTenantEntity
    {
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
        public virtual Phone Phone { get; set; }
        public int PhoneId { get; set; }
        public bool IsActive { get; set; }
    }
}