using Abp.EntityFramework;
using Project.Domain;
using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.EntityFramework.Repositories
{
    public class AddressRepository : ProjectRepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Address>> GetAllByCity(int cityId)
        {
            return await GetAllListAsync(x => x.CityId == cityId);
        }

        public async Task<List<Address>> GetAllByDepartment(int departmentId)
        {
            return await GetAllListAsync(x => x.City.DepartmentId == departmentId);
        }

        public async Task<List<Address>> GetAllByCountry(int countryId)
        {
            return await GetAllListAsync(x => x.City.Department.CountryId == countryId);
        }
    }
}