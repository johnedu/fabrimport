using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IInvoiceRepository : IProjectRepositoryBase<Invoice>
    {
        Task<List<Invoice>> GetAllByState(int stateId);
    }
}