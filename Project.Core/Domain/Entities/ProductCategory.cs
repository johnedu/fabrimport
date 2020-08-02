using Project.Domain.BaseEntity;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class ProductCategory : MultiTenantEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int LastCodeNumber { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            Products = new List<Product>();
        }
    }
}