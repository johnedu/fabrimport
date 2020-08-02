using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class CompanyPhoneRepository : ProjectRepositoryBase<CompanyPhone>, ICompanyPhoneRepository
    {
        public CompanyPhoneRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}