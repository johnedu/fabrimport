using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public interface IOrderRepository : IProjectRepositoryBase<Order>
    {
        Task<List<Order>> GetAllByFilters(int? employeeId, int? customerId, int? stateId, DateTime? startDate, DateTime? endDate);
    }
}