using Project.Domain;

namespace Project.ProjectApplication.Sales.InventoryApp
{
    public class InventoryAppService : AppServiceBase, IInventoryAppService
    {
        #region Repositories
        private readonly IInventoryInputRepository _inventoryInputRepository;
        private readonly IInventoryOutputRepository _inventoryOutputRepository;
        #endregion

        public InventoryAppService(IInventoryInputRepository inventoryInputRepository,
                                   IInventoryOutputRepository inventoryOutputRepository)
        {
            _inventoryInputRepository = inventoryInputRepository;
            _inventoryOutputRepository = inventoryOutputRepository;
        }
    }
}
