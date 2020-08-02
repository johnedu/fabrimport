using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.PersonApp.DTOs.OutputModels
{
    [AutoMap(typeof(Phone))]
    public class PhoneOutput : EntityDto
    {
        public string Number { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}