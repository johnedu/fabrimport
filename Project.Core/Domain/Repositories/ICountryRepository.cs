using Project.Domain.Entities;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface ICountryRepository : IProjectRepositoryBase<Country>
    {
        Task<Country> GetByName(string name);
    }
}