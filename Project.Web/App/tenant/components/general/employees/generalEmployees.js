(function () {
    appModule.component('generalEmployees', {
        controller: ['abp.services.app.employee', generalEmployeesController],
        templateUrl: '/app/tenant/components/general/employees/generalEmployees.cshtml'
    });

    function generalEmployeesController(employeeServvice) {
        var $ctrl = this;

        
        $ctrl.$onInit = function () {
            
        };
    }
})();