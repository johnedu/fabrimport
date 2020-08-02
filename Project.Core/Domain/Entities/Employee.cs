using Project.Authorization.Users;
using Project.Domain.BaseEntity;
using System;
using System.Collections.Generic;

namespace Project.Domain.Entities
{
    public class Employee : MultiTenantEntity
    {
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }
        public virtual User User { get; set; }
        public long UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Employee()
        {
            Orders = new List<Order>();
        }
    }
}