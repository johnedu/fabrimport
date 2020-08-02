using Abp.AutoMapper;
using Project.Domain.Entities;
using System;

namespace Project.ProjectApplication.General.PersonApp.DTOs.InputModels
{
    [AutoMap(typeof(Person))]
    public class PersonInput
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? BirthdayDate { get; set; }
        public string Gender { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
    }
}