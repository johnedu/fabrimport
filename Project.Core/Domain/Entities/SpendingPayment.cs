using Project.Domain.BaseEntity;
using System;

namespace Project.Domain.Entities
{
    public class SpendingPayment : MultiTenantEntity
    {
        public virtual Spending Spending { get; set; }
        public int SpendingId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Value { get; set; }
    }
}