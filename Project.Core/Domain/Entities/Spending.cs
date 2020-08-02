using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Spending : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual Type Type { get; set; }
        public int TypeId { get; set; }
        public virtual State State { get; set; }
        public int StateId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int? InvoiceId { get; set; }
        public virtual Order Order { get; set; }
        public int? OrderId { get; set; }
        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyId { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<SpendingPayment> SpendingPayments { get; set; }

        public Spending()
        {
            SpendingPayments = new List<SpendingPayment>();
        }
    }
}