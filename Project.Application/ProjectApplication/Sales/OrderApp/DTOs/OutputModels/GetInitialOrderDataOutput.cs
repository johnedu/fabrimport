using Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels;
using Project.ProjectApplication.General.EmployeeApp.DTOs.OutputModels;
using Project.ProjectApplication.General.ProductApp.DTOs.OutputModels;
using System.Collections.Generic;

namespace Project.ProjectApplication.Sales.OrderApp.DTOs.OutputModels
{
    public class GetInitialOrderDataOutput
    {
        public List<EmployeeOutput> Employees { get; set; }
        public List<CustomerOutput> Customers { get; set; }
        public List<BasicProductOutput> Products { get; set; }
    }
}