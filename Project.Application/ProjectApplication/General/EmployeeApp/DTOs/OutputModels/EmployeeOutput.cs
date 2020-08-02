using Abp.AutoMapper;
using Project.Domain.Entities;
using Project.ProjectApplication.General.PersonApp.DTOs.OutputModels;

namespace Project.ProjectApplication.General.EmployeeApp.DTOs.OutputModels
{
    [AutoMap(typeof(Employee))]
    public class EmployeeOutput
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public long UserId { get; set; }
    }
}