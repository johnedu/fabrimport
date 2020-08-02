(function () {
    appModule.directive(
        'inputDatePicker',
        function (dateFilter) {
            return {
                restrict: 'E',
                require: 'ngModel',
                replace: true,
                scope: {
                    elementId: '@',
                    ngModel: '=',
                    dateOptions: '=',
                    validDate: '=',
                    edadCalculada: '=',
                    validDateSelected: '&',
                    onFocusFecha: '&'
                },
                link: function ($scope, element, attrs, ngModelCtrl) {
                    ngModelCtrl.$formatters.unshift(function (modelValue) {
                        return dateFilter(modelValue, 'yyyy-MM-dd');
                    });
                    ngModelCtrl.$parsers.unshift(function (viewValue) {
                        return new Date(viewValue);
                    });
                    $scope.fechaCambiada = function () {
                        if ($scope.ngModel > new Date($scope.dateOptions.fechaMaxima + " 23:59:59")) {
                            $scope.formInputDatePicker.inputDatePicker.$error.max = true;
                            $scope.formInputDatePicker.inputDatePicker.$valid = false;
                            $scope.formInputDatePicker.inputDatePicker.$invalid = true;
                        }
                        $scope.validDate = $scope.formInputDatePicker.inputDatePicker.$valid;
                        if ($scope.validDate) {
                            $scope.validDateSelected({ fecha: $scope.ngModel });
                        }
                    };
                    $scope.focusFecha = function () {
                        $scope.validDate = $scope.formInputDatePicker.inputDatePicker.$valid;
                        if ($scope.validDate) {
                            $scope.onFocusFecha({ fecha: $scope.ngModel });
                        }
                    };
                    $scope.$watch(function ($scope) { return $scope.dateOptions; }, function (newValue, oldValue) {
                        if (newValue) {
                            if (newValue.fechaMaxima) {
                                $scope.fechaMaximaActualizada = moment(newValue.fechaMaxima).add(1, 'days').format("YYYY-MM-DD");
                            }
                            else {
                                $scope.fechaMaximaActualizada = undefined;
                            }
                            $scope.mensajeErrorFechaMinima = String.format(app.localize('InputDatePickerFechaInferiorMinima'), newValue.fechaMinima);
                            $scope.mensajeErrorFechaMaxima = String.format(app.localize('InputDatePickerFechaSuperiorMaxima'), newValue.fechaMaxima);
                        }
                        else {
                            $scope.fechaMaximaActualizada = undefined;
                        }
                    });
                },
                templateUrl: '/App/common/directives/projectDirectives/datePicker/inputDatePicker.cshtml',
            };
        });
})();