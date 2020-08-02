using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels
{
    [AutoMap(typeof(Order))]
    public class OrderOutput : EntityDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int OrderStateId { get; set; }
        public string OrderStateName { get; set; }
        public decimal CostValue { get; set; }
        public decimal SaleValue { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? CancelledDate { get; set; }
        public List<OrderProductOutput> Products { get; set; }
    }
}