using System.Collections.Generic;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels
{
    public class GetAllOrdersOutput
    {
        public List<ListOrderOutput> Orders { get; set; }
    }
}