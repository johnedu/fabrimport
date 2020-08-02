using Project.Domain.Entities;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface ITypeRepository : IProjectRepositoryBase<Type>
    {
        Task<Type> GetByName(string typeName);
    }
}