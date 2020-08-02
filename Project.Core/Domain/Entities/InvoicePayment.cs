using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class InvoicePayment : MultiTenantEntity
    {
        public virtual Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}