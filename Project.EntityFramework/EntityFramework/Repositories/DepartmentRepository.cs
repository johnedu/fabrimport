using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class DepartmentRepository : ProjectRepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<Department> GetByNameAndCountry(string name, int countryId)
        {
            return await FirstOrDefaultAsync(x => x.Name == name && x.CountryId == countryId);
        }

        public async Task DeleteByCountry(int countryId)
        {
            await DeleteAsync(x => x.CountryId == countryId);
        }
    }
}