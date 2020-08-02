(function () {
    appModule.component('generalProducts', {
        controller: ['abp.services.app.product', generalProductsController],
        templateUrl: '/app/tenant/components/general/products/generalProducts.cshtml'
    });

    function generalProductsController(productService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();