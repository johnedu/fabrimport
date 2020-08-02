using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IEmployeeRepository : IProjectRepositoryBase<Employee>
    {
        Task<List<Employee>> GetAllByState(bool? isActive);
    }
}