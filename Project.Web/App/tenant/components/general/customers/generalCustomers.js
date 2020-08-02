(function () {
    appModule.component('generalCustomers', {
        controller: ['abp.services.app.customer', generalCustomersController],
        templateUrl: '/app/tenant/components/general/customers/generalCustomers.cshtml'
    });

    function generalCustomersController(customerService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();