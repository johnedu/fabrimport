using Abp.AutoMapper;
using Project.Domain.Entities;

namespace Project.ProjectApplication.General.ProductApp.DTOs.InputModels
{
    [AutoMap(typeof(SetProduct))]
    public class SetProductInput
    {
        public int? Id { get; set; }
        public virtual ProductInput Product { get; set; }
        public int Quantity { get; set; }
    }
}