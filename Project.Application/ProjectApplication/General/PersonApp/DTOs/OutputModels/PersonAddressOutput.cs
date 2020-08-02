using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.PersonApp.DTOs.OutputModels
{
    [AutoMap(typeof(PersonAddress))]
    public class PersonAddressOutput
    {
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public AddressOutput Address { get; set; }
        public bool IsActive { get; set; }
    }
}