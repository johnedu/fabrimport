using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Address : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual City City { get; set; }
        public int CityId { get; set; }
        public bool IsMain { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        public Address()
        {
            Companies = new List<Company>();
            PersonAddresses = new List<PersonAddress>();
        }
    }
}