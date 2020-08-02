(function () {
    appModule.component('salesInventory', {
        controller: ['abp.services.app.inventory', salesInventoryController],
        templateUrl: '/app/tenant/components/sales/inventory/salesInventory.cshtml'
    });

    function salesInventoryController(inventoryService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();