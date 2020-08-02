(function () {
    appModule.component('generalZoning', {
        controller: ['abp.services.app.zoning', generalZoningController],
        templateUrl: '/app/tenant/components/general/zoning/generalZoning.cshtml'
    });

    function generalZoningController(zoningService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();