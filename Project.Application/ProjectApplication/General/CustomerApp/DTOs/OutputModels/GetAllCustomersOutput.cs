using System.Collections.Generic;

namespace Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels
{
    public class GetAllCustomersOutput
    {
        public List<CustomerOutput> Customers { get; set; }
    }
}