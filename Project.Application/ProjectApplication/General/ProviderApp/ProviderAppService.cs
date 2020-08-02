using Project.Domain;

namespace Project.ProjectApplication.General.ProviderApp
{
    public class ProviderAppService : AppServiceBase, IProviderAppService
    {
        #region Repositories
        private readonly IProviderRepository _providerRepository;
        #endregion

        public ProviderAppService(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }
    }
}
