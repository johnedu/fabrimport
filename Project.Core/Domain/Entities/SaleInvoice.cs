using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class SaleInvoice : MultiTenantEntity
    {
        public int Number { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? CancelledDate { get; set; }

        public virtual ICollection<SaleInvoicePayment> Payments { get; set; }

        public SaleInvoice()
        {
            Payments = new List<SaleInvoicePayment>();
        }
    }
}