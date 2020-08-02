using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Product : MultiTenantEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsSet { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<SetProduct> SetProducts { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }

        public Product()
        {
            InvoiceProducts = new List<InvoiceProduct>();
            SetProducts = new List<SetProduct>();
            OrderProducts = new List<OrderProduct>();
            ProductPrices = new List<ProductPrice>();
        }
    }
}