using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.PersonApp.DTOs.OutputModels
{
    [AutoMap(typeof(Address))]
    public class AddressOutput : EntityDto
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsMain { get; set; }
    }
}