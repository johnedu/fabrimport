using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class InventoryInput : MultiTenantEntity
    {
        public virtual InvoiceProduct InvoiceProduct { get; set; }
        public int InvoiceProductId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public int Quantity { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; }
        public DateTime? SoldDate { get; set; }
    }
}