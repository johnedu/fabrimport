using Project.Domain.Entities;

namespace Project.EntityFramework.Mappings
{
    public class InventoryOutputMap : MultiTenantMap<InventoryOutput>
    {
        public InventoryOutputMap()
        {
            //  TABLE NAME
            ToTable("inventory_output");
        }
    }
}