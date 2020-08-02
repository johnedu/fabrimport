using Abp.AutoMapper;
using Project.Domain.Entities;
using System.Collections.Generic;

namespace Project.ProjectApplication.General.ProductApp.DTOs.InputModels
{
    [AutoMap(typeof(Product))]
    public class ProductInput
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsSet { get; set; }
        public int ProductCategoryId { get; set; }
        public List<SetProductInput> SetProductsInput { get; set; }
    }
}