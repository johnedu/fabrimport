using Abp.EntityFramework;
using Project.Domain.Entities;
using Project.EntityFramework;
using Project.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class OrderRepository : ProjectRepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbContextProvider<ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Order>> GetAllByFilters(int? employeeId, int? customerId, int? stateId, DateTime? startDate, DateTime? endDate)
        {
            return await GetAllListAsync(x => (!employeeId.HasValue || employeeId.Value == x.EmployeeId) &&
                                              (!customerId.HasValue || customerId.Value == x.CustomerId) &&
                                              (!stateId.HasValue || stateId.Value == x.OrderStateId) &&
                                              (!startDate.HasValue || (startDate.Value <= x.Date && endDate.Value >= x.Date)));
        }
    }
}