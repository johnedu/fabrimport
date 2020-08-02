using Project.Domain;

namespace Project.ProjectApplication.General.PersonApp
{
    public class PersonaAppService : AppServiceBase, IPersonaAppService
    {
        #region Repositories
        private readonly IPersonRepository _personRepository;
        #endregion

        public PersonaAppService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
    }
}
