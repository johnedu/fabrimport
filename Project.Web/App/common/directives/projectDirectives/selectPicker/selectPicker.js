(function () {
    appModule.directive('selectPicker', ['$timeout', function ($timeout) {
        return {
            restrict: 'E',
            replace: true,
            scope: {
                elementId: '@',
                opciones: '=',
                opcionSeleccionada: '=',
                seleccionoOpcion: '&',
                textoNoSeleccion: '@',
                mostrarBuscador: '@',
                notificarSeleccion: '@',
                deshabilitado: '=deshabilitado'
            },
            link: function ($scope, element, attrs) {

                //POR DEFECTO SE MUESTRA EL SELECT CON BUSCADOR
                if ($scope.mostrarBuscador == undefined) {
                    $scope.mostrarBuscador = true;
                };

                //POR DEFECTO NOTIFICA CAMBIOS DE ngModel
                if ($scope.notificarSeleccion == undefined) {
                    $scope.notificarSeleccion = true;
                };

                if ($scope.notificarSeleccion == 'NO') {
                    $scope.notificarSeleccion = false;
                };

                $scope.$watch(function ($scope) { return $scope.opciones }, function (newValue, oldValue) {
                    $(element).selectpicker('refresh');
                    $(element).selectpicker('val', $scope.opcionSeleccionada);
                });

                $scope.$watch(function ($scope) { return $scope.opcionSeleccionada }, function (newValue, oldValue) {
                    $(element).selectpicker('val', $scope.opcionSeleccionada);
                    if ($scope.notificarSeleccion != 'NO') {
                        $scope.seleccionoOpcion({ option: $scope.opcionSeleccionada });
                    }
                });

                $scope.$watch(function ($scope) { return $scope.deshabilitado }, function (newValue, oldValue) {
                    $(element).selectpicker('refresh');
                });
            },
            templateUrl: '/App/common/directives/projectDirectives/selectPicker/selectPicker.cshtml'
        };
    }]);
})();