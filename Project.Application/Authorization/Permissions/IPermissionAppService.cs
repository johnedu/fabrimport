using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Project.Authorization.Permissions.Dto;

namespace Project.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
