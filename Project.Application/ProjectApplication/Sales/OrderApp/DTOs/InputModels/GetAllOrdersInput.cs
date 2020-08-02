using System;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.InputModels
{
    public class GetAllOrdersInput
    {
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        public int? StateId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}