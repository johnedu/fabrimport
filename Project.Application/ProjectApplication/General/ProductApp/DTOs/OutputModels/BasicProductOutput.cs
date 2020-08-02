using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.ProductApp.DTOs.OutputModels
{
    [AutoMap(typeof(Product))]
    public class BasicProductOutput : EntityDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsSet { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}