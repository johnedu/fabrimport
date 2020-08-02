using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class PhoneRepository : ProjectRepositoryBase<Phone>, IPhoneRepository
    {
        public PhoneRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Phone>> GetAllByCity(int cityId)
        {
            return await GetAllListAsync(x => x.CityId == cityId);
        }

        public async Task<List<Phone>> GetAllByDepartment(int departmentId)
        {
            return await GetAllListAsync(x => x.City.DepartmentId == departmentId);
        }

        public async Task<List<Phone>> GetAllByCountry(int countryId)
        {
            return await GetAllListAsync(x => x.City.Department.CountryId == countryId);
        }
    }
}