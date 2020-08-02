using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class InventoryOutput : MultiTenantEntity
    {
        public virtual OrderProduct OrderProduct { get; set; }
        public int OrderProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Earnings { get; set; }
        public DateTime Date { get; set; }
    }
}