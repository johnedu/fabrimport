using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Order : MultiTenantEntity
    {
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual State OrderState { get; set; }
        public int OrderStateId { get; set; }
        public decimal CostValue { get; set; }
        public decimal SaleValue { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? CancelledDate { get; set; }

        public virtual ICollection<OrderProduct> Products { get; set; }
        public virtual ICollection<Spending> Spendings { get; set; }
        public virtual ICollection<SaleInvoice> SaleInvoices { get; set; }

        public Order()
        {
            Products = new List<OrderProduct>();
            Spendings = new List<Spending>();
            SaleInvoices = new List<SaleInvoice>();
        }
    }
}