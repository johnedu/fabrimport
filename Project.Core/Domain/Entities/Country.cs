using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Country : MultiTenantEntity
    {
        public string Name { get; set; }
        public string ISOCode { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }

        public Country()
        {
            Departments = new List<Department>();
            Phones = new List<Phone>();
        }
    }
}