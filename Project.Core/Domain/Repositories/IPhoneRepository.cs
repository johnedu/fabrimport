using Project.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IPhoneRepository : IProjectRepositoryBase<Phone>
    {
        Task<List<Phone>> GetAllByCity(int cityId);
        Task<List<Phone>> GetAllByDepartment(int departmentId);
        Task<List<Phone>> GetAllByCountry(int countryId);
    }
}