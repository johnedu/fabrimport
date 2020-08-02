using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Invoice : MultiTenantEntity
    {
        public virtual Provider Provider { get; set; }
        public int ProviderId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public int Number { get; set; }
        public decimal Value { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? PaymentDate { get; set; }

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }
        public virtual ICollection<Spending> InvoiceSpendings { get; set; }

        public Invoice()
        {
            InvoiceProducts = new List<InvoiceProduct>();
            InvoicePayments = new List<InvoicePayment>();
            InvoiceSpendings = new List<Spending>();
        }
    }
}