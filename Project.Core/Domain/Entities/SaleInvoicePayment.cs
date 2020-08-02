using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class SaleInvoicePayment : MultiTenantEntity
    {
        public virtual SaleInvoice SaleInvoice { get; set; }
        public int SaleInvoiceId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}