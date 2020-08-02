using Project.Domain.BaseEntity;

namespace Project.Domain.Entities
{
    public class SetProduct : MultiTenantEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}