(function () {
    appModule.component('salesInvoices', {
        controller: ['abp.services.app.invoice', salesInvoicesController],
        templateUrl: '/app/tenant/components/sales/invoices/salesInvoices.cshtml'
    });

    function salesInvoicesController(invoiceService) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();