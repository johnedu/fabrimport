using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Phone : MultiTenantEntity
    {
        public string Number { get; set; }
        public virtual City City { get; set; }
        public int? CityId { get; set; }
        public virtual Country Country { get; set; }
        public int? CountryId { get; set; }
        public virtual Type Type { get; set; }
        public int TypeId { get; set; }

        public virtual ICollection<CompanyPhone> CompanyPhones { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }

        public Phone()
        {
            CompanyPhones = new List<CompanyPhone>();
            PersonPhones = new List<PersonPhone>();
        }
    }
}