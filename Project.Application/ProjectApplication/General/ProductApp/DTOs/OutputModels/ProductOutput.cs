using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Project.ProjectApplication.General.ProductApp.DTOs.OutputModels
{
    [AutoMap(typeof(Product))]
    public class ProductOutput : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsSet { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<SetProductOutput> SetProducts { get; set; }
        public List<ProductPriceOutput> ProductPrices { get; set; }
    }
}