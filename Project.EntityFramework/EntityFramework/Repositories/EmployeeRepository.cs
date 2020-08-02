using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class EmployeeRepository : ProjectRepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Employee>> GetAllByState(bool? isActive)
        {
            return await GetAllListAsync(x => !isActive.HasValue || x.IsActive == isActive.Value);
        }
    }
}