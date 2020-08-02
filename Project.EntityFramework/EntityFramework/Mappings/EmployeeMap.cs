using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class EmployeeMap : MultiTenantMap<Employee>
    {
        public EmployeeMap()
        {
            //  FOREIGN KEYS
            HasMany(employee => employee.Orders)
              .WithRequired(order => order.Employee)
              .HasForeignKey(order => order.EmployeeId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("employee");
        }
    }
}