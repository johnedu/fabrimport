using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels
{
    [AutoMap(typeof(OrderProduct))]
    public class OrderProductOutput : EntityDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}