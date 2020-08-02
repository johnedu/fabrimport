using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;

namespace Project.Domain
{
    public class PersonPhoneRepository : ProjectRepositoryBase<PersonPhone>, IPersonPhoneRepository
    {
        public PersonPhoneRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}