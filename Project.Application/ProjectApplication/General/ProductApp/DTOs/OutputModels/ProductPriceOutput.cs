using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Project.Domain.Entities;
using System;

namespace Project.ProjectApplication.General.ProductApp.DTOs.OutputModels
{
    [AutoMap(typeof(ProductPrice))]
    public class ProductPriceOutput : EntityDto
    {
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}