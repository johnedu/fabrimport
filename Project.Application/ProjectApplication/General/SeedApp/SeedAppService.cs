using Project.Domain.DomainServices;
using System.Threading.Tasks;

namespace Project.ProjectApplication.General.SeedApp
{
    public class SeedAppService : AppServiceBase, ISeedAppService
    {
        #region Repositories
        private readonly ISeedDomainService _seedDomainService;
        #endregion

        public SeedAppService(ISeedDomainService seedDomainService)
        {
            _seedDomainService = seedDomainService;
        }

        public async Task RunSeed()
        {
            await _seedDomainService.CargarSeed(AbpSession.TenantId.Value);
        }
    }
}
