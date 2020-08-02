using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Project.Editions.Dto;

namespace Project.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}