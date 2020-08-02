using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class ParameterMap : MultiTenantMap<Parameter>
    {
        public ParameterMap()
        {
            //  FOREIGN KEYS
            HasMany(parameter => parameter.Types)
              .WithRequired(type => type.Parameter)
              .HasForeignKey(type => type.ParameterId)
              .WillCascadeOnDelete(false);

            //  TABLE NAME
            ToTable("parameter");
        }
    }
}