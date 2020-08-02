using Project.Domain;

namespace Project.ProjectApplication.General.EmployeeApp
{
    public class EmployeeAppService : AppServiceBase, IEmployeeAppService
    {
        #region Repositories
        private readonly IEmployeeRepository _employeeRepository;
        #endregion

        public EmployeeAppService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}
