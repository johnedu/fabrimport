using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class InventoryInputMap : MultiTenantMap<InventoryInput>
    {
        public InventoryInputMap()
        {
            //  TABLE NAME
            ToTable("inventory_input");
        }
    }
}