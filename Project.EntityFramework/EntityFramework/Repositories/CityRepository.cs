using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class CityRepository : ProjectRepositoryBase<City>, ICityRepository
    {
        public CityRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<City> GetByNameAndDepartment(string name, int departmentId)
        {
            return await FirstOrDefaultAsync(x => x.Name == name && x.DepartmentId == departmentId);
        }

        public async Task DeleteByCountry(int countryId)
        {
            await DeleteAsync(x => x.Department.CountryId == countryId);
        }

        public async Task DeleteByDepartment(int departmentId)
        {
            await DeleteAsync(x => x.DepartmentId == departmentId);
        }
    }
}