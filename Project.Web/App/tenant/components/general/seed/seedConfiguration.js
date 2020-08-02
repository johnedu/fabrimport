(function () {
    appModule.component('seedConfiguration', {
        controller: ['abp.services.app.seed', seedConfigurationController],
        templateUrl: '/app/tenant/components/general/seed/seedConfiguration.cshtml'
    });

    function seedConfigurationController(seedService) {
        var $ctrl = this;

        $ctrl.runSeed = function() {
            $ctrl.runningSeed = true;
            seedService.runSeed().then(function () {
                abp.notify.success("Seed Ejecutado");
            }, function (error) {
                abp.notify.error("Error ejecutando el seed");
                console.log('Error ejecutando el seed: ', error);
            }).finally(function () {
                $ctrl.runningSeed = false;
            });
        };
    }
})();