using Abp.Application.Services;
using Project.Tenants.Dashboard.Dto;

namespace Project.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
