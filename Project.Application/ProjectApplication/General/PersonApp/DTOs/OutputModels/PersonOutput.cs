using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Project.ProjectApplication.General.PersonApp.DTOs.OutputModels
{
    [AutoMap(typeof(Person))]
    public class PersonOutput : EntityDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string FullName { get; set; }
        public int? DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? BirthdayDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public List<PersonPhoneOutput> Phones { get; set; }
        public List<PersonAddressOutput> Addresses { get; set; }
    }
}