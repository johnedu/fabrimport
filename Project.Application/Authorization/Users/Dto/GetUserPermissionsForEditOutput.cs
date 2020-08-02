using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Project.Authorization.Permissions.Dto;

namespace Project.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}