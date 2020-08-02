(function () {
    appModule.component('generalProviders', {
        controller: ['abp.services.app.provider', generalProvidersController],
        templateUrl: '/app/tenant/components/general/providers/generalProviders.cshtml'
    });

    function generalProvidersController(providerService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();