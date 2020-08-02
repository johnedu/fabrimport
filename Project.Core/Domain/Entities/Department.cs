using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Department : MultiTenantEntity
    {
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public Department()
        {
            Cities = new List<City>();
        }
    }
}