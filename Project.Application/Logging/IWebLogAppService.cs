using Abp.Application.Services;
using Project.Dto;
using Project.Logging.Dto;

namespace Project.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
