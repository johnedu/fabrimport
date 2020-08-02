using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class InvoiceProduct : MultiTenantEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public int Quantity { get; set; }
        public int RealQuantity { get; set; }
        public decimal Value { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public virtual ICollection<InventoryInput> InventoryInputs { get; set; }

        public InvoiceProduct()
        {
            InventoryInputs = new List<InventoryInput>();
        }
    }
}