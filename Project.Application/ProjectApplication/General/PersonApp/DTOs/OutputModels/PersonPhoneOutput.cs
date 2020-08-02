using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.PersonApp.DTOs.OutputModels
{
    [AutoMap(typeof(PersonPhone))]
    public class PersonPhoneOutput
    {
        public int PersonId { get; set; }
        public int PhoneId { get; set; }
        public PhoneOutput Phone { get; set; }
        public bool IsActive { get; set; }
    }
}