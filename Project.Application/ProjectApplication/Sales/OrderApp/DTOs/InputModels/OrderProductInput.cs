using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.InputModels
{
    [AutoMap(typeof(OrderProduct))]
    public class OrderProductInput
    {
        public int? Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsUpdatedRecord { get; set; }
    }
}