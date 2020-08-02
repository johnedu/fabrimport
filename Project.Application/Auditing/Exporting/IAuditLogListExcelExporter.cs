using System.Collections.Generic;
using Project.Auditing.Dto;
using Project.Dto;

namespace Project.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
