using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class CountryRepository : ProjectRepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<Country> GetByName(string name) {
            return await FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}