using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Parameter : MultiTenantEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Type> Types { get; set; }

        public Parameter()
        {
            Types = new List<Type>();
        }
    }
}