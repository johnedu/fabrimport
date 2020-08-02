using Project.Domain.BaseEntity;
using System.Data.Entity.ModelConfiguration;

namespace Project.EntityFramework.Mappings
{
    public class MultiTenantMap<TMultiTenantEntidad> : EntityTypeConfiguration<TMultiTenantEntidad>
        where TMultiTenantEntidad : class, IMultiTenant
    {
        public MultiTenantMap() : base()
        {
            //Llave Primaria
            HasKey(mt => mt.Id);

            //Propiedad de TenantId
            Property(mt => mt.TenantId).IsRequired();
        }
    }
}