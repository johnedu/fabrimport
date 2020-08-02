using Project.Domain.BaseEntity;

namespace Project.Domain.Entities
{
    public class CompanyPhone : MultiTenantEntity
    {
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
        public virtual Phone Phone { get; set; }
        public int PhoneId { get; set; }
        public bool IsActive { get; set; }
    }
}