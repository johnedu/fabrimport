using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IAddressRepository : IProjectRepositoryBase<Address>
    {
        Task<List<Address>> GetAllByCity(int cityId);
        Task<List<Address>> GetAllByDepartment(int departmentId);
        Task<List<Address>> GetAllByCountry(int countryId);
    }
}