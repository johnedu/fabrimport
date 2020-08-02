using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class ProductPrice : MultiTenantEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}