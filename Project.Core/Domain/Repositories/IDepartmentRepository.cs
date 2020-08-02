using Project.Domain.Entities;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IDepartmentRepository : IProjectRepositoryBase<Department>
    {
        Task<Department> GetByNameAndCountry(string name, int countryId);
        Task DeleteByCountry(int countryId);
    }
}