namespace Project.Domain.DomainServices
{
    public class ZoningDomainService : ProjectDomainServiceBase, IZoningDomainService
    {
        #region Repositorios
        private readonly ITypeRepository _typeRepository;
        #endregion

        public ZoningDomainService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
    }
}