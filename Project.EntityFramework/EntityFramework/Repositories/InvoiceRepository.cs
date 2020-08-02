using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class InvoiceRepository : ProjectRepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Invoice>> GetAllByState(int stateId)
        {
            return await GetAllListAsync(x => x.StateId == stateId);
        }
    }
}