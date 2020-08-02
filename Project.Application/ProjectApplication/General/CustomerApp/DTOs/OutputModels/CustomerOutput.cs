using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using System;

namespace Project.ProjectApplication.General.CustomerApp.DTOs.OutputModels
{
    [AutoMap(typeof(Customer))]
    public class CustomerOutput : EntityDto
    {
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}