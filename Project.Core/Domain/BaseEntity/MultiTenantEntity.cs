using Abp.Domain.Entities;

namespace Project.Domain.BaseEntity
{
    public class MultiTenantEntity: Entity, IMultiTenant, IMustHaveTenant 
    {
        public int TenantId { get; set; }
    }
}