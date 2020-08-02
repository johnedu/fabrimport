using Abp.AutoMapper;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.InputModels
{
    [AutoMap(typeof(Order))]
    public class SaveOrderInput
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public decimal SaleValue { get; set; }
        public DateTime Date { get; set; }
        public List<OrderProductInput> OrderProducts { get; set; }
    }
}