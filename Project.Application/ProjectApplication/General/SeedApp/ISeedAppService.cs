using Abp.Application.Services;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.SeedApp
{
    public interface ISeedAppService : IApplicationService
    {
        Task RunSeed();
    }
}