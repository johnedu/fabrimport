namespace Project.Domain.DomainServices
{
    public class ParametersDomainService : ProjectDomainServiceBase, IParametersDomainService
    {
        #region Repositorios
        private readonly ITypeRepository _typeRepository;
        private readonly IStateRepository _stateRepository;
        #endregion

        public ParametersDomainService(ITypeRepository typeRepository,
                                       IStateRepository stateRepository)
        {
            _typeRepository = typeRepository;
            _stateRepository = stateRepository;
        }
    }
}