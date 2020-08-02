using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class DepartmentMap : MultiTenantMap<Department>
    {
        public DepartmentMap()
        {
            //  FOREIGN KEYS
            HasMany(department => department.Cities)
              .WithRequired(city => city.Department)
              .HasForeignKey(city => city.DepartmentId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("department");
        }
    }
}