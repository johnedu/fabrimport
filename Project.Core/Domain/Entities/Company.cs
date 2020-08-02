using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Company : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }
        public virtual Type DocumentType { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public virtual Person Representante { get; set; }
        public int RepresentanteId { get; set; }

        public virtual ICollection<CompanyPhone> Phones { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public Company()
        {
            Phones = new List<CompanyPhone>();
            Customers = new List<Customer>();
        }
    }
}