using Project.Domain.Entities;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface ICityRepository : IProjectRepositoryBase<City>
    {
        Task<City> GetByNameAndDepartment(string name, int departmentId);
        Task DeleteByCountry(int countryId);
        Task DeleteByDepartment(int departmentId);
    }
}