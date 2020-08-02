using Abp.Domain.Entities;

namespace Project.Domain.BaseEntity
{
    public interface IMultiTenant : IEntity
    {
        int TenantId { get; set; }
    }
}