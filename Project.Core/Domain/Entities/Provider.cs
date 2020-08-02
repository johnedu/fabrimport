using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Provider : MultiTenantEntity
    {
        public virtual Person Person { get; set; }
        public int? PersonId { get; set; }
        public virtual Company Company { get; set; }
        public int? CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public Provider()
        {
            Invoices = new List<Invoice>();
        }
    }
}