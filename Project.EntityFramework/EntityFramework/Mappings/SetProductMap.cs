using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class SetProductMap : MultiTenantMap<SetProduct>
    {
        public SetProductMap()
        {
            //  TABLE NAME
            ToTable("set_product");
        }
    }
}