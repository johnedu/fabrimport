using System.Threading.Tasks;
using Project.Sessions.Dto;

namespace Project.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
