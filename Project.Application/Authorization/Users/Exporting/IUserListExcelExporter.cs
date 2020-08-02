using System.Collections.Generic;
using Project.Authorization.Users.Dto;
using Project.Dto;

namespace Project.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}