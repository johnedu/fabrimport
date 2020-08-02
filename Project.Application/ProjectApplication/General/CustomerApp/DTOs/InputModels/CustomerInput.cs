using Abp.AutoMapper;
using Project.Domain.Entities;
using System.Collections.Generic;

namespace Project.ProjectApplication.General.CustomerApp.DTOs.InputModels
{
    [AutoMap(typeof(Customer))]
    public class CustomerInput
    {
        public int? Id { get; set; }
        public int? PersonId { get; set; }
        public int? CompanyId { get; set; }
    }
}