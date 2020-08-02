using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.ProductApp.DTOs.OutputModels
{
    [AutoMap(typeof(SetProduct))]
    public class SetProductOutput : EntityDto
    {
        public virtual ProductOutput Product { get; set; }
        public int Quantity { get; set; }
    }
}