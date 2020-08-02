using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class State : MultiTenantEntity
    {
        public string Name { get; set; }
        public Type StateType { get; set; }
        public int StateTypeId { get; set; }
        public bool Locked { get; set; }

        public virtual ICollection<Invoice> InvoiceStates { get; set; }
        public virtual ICollection<InvoicePayment> InvoicePaymentStates { get; set; }
        public virtual ICollection<InventoryInput> InventoryInputStates { get; set; }
        public virtual ICollection<Order> OrderStates { get; set; }
        public virtual ICollection<SaleInvoice> SaleInvoiceStates { get; set; }
        public virtual ICollection<SaleInvoicePayment> SaleInvoicePaymentStates { get; set; }
        public virtual ICollection<Spending> SpendingStates { get; set; }
        public virtual ICollection<SpendingPayment> SpendingPaymentStates { get; set; }

        public State()
        {
            InvoiceStates = new List<Invoice>();
            InvoicePaymentStates = new List<InvoicePayment>();
            InventoryInputStates = new List<InventoryInput>();
            OrderStates = new List<Order>();
            SaleInvoiceStates = new List<SaleInvoice>();
            SaleInvoicePaymentStates = new List<SaleInvoicePayment>();
            SpendingStates = new List<Spending>();
            SpendingPaymentStates = new List<SpendingPayment>();
        }
    }
}