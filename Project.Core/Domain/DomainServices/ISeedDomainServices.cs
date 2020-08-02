using Abp.Domain.Services;
using System.Threading.Tasks;

namespace Project.Domain.DomainServices
{
    public interface ISeedDomainService : IDomainService
    {
        Task CargarSeed(int tenantId);
    }
}