using Project.Domain;
using Project.Domain.DomainServices;

namespace Project.ProjectApplication.General.ZoningApp
{
    public class ZoningAppService : AppServiceBase, IZoningAppService
    {
        #region Repositories
        private readonly ICountryRepository _countryRepository;
        #endregion

        #region Domain Services
        private readonly IZoningDomainService _zoningDomainService;
        #endregion

        public ZoningAppService(ICountryRepository countryRepository,

                                IZoningDomainService zoningDomainService)
        {
            _countryRepository = countryRepository;

            _zoningDomainService = zoningDomainService;
        }
    }
}
