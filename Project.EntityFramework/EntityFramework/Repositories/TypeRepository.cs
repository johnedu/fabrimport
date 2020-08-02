using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class TypeRepository : ProjectRepositoryBase<Type>, ITypeRepository
    {
        public TypeRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<Type> GetByName(string typeName)
        {
            return await FirstOrDefaultAsync(x => string.Equals(x.Name, typeName));
        }
    }
}