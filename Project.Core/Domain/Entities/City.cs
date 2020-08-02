using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class City : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }

        public City()
        {
            Addresses = new List<Address>();
            Phones = new List<Phone>();
        }
    }
}