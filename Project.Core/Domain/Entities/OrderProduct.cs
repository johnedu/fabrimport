using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class OrderProduct : MultiTenantEntity
    {
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }

        public virtual ICollection<InventoryOutput> InventoryOutputs { get; set; }

        public OrderProduct()
        {
            InventoryOutputs = new List<InventoryOutput>();
        }
    }
}