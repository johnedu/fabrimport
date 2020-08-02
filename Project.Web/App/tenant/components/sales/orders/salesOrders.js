(function () {
    appModule.component('salesOrders', {
        controller: ['abp.services.app.order', salesOrdersController],
        templateUrl: '/app/tenant/components/sales/orders/salesOrders.cshtml'
    });

    function salesOrdersController(orderService) {
        var $ctrl = this;
        $ctrl.render = {
            showOrders: true
        };
        $ctrl.options = {};
        $ctrl.order = {};

        $ctrl.$onInit = function () {
            $ctrl.order.orderProducts = [
                {
                    position: 1,
                    quantity: 0,
                    saleValue: 0,
                    totalValue: 0
                }
            ];
            getInitialOrderData();
        };
       
        function getInitialOrderData() {
            orderService.getInitialOrderData().then(function (result) {
                $ctrl.options.customers = _.map(result.data.customers, function (customer) {
                    customer.name = customer.personName;
                    return customer;
                });
                $ctrl.options.employees = _.map(result.data.employees, function (employee) {
                    employee.name = employee.personName;
                    return employee;
                });
                $ctrl.options.products = result.data.products;
            });
        }

        $ctrl.customerSelected = function (option) {
            if (option) {
                var customerPerson = _.find($ctrl.options.customers, function (customer) {
                    return customer.id = option;
                });
                orderService.getCustomerPersonData({ id: customerPerson.personId }).then(function (result) {
                    $ctrl.order.customer = result.data.customerPerson;
                    $ctrl.order.customer.documentTypeName = app.localize($ctrl.order.customer.documentTypeName);
                    var mainAddress = _.find($ctrl.order.customer.addresses, function (address) {
                        return address.address.isMain;
                    });
                    $ctrl.order.customer.mainAddress = mainAddress.address;
                });
            }
        };

        $ctrl.productSelected = function (option, orderProduct) {
            if (option) {
                var productFinded = _.find($ctrl.options.products, function (product) {
                    return product.id === option;
                });
                orderProduct.productCode = productFinded ? productFinded.code : '';
            }
        };
        
        $ctrl.deleteOrderProduct = function (position) {
            $ctrl.order.orderProducts = _.filter($ctrl.order.orderProducts, function (orderProduct) {
                return orderProduct.position !== position;
            });
        };

        $ctrl.addOrderProduct = function () {
            var lastOrderProduct = _.last($ctrl.order.orderProducts);
            $ctrl.order.orderProducts.push({
                position: lastOrderProduct.position + 1,
                quantity: 0,
                saleValue: 0,
                totalValue: 0
            });
        };

        $ctrl.getOrderTotalValue = function () {
            $ctrl.orderTotal = _.reduce($ctrl.order.orderProducts, function (memorizer, product) {
                return memorizer + product.totalValue;
            }, 0);
            return $ctrl.orderTotal;
        };
        
        $ctrl.newOrder = function () {
            $ctrl.order.orderProducts = [
                {
                    position: 1,
                    quantity: 0,
                    saleValue: 0,
                    totalValue: 0
                }
            ];
            $ctrl.render.showOrders = false;
        };

        $ctrl.saveOrder = function () {
            orderService.getCustomerPersonData({ id: customerPerson.personId }).then(function (result) {
                $ctrl.order.customer = result.data.customerPerson;
                $ctrl.order.customer.documentTypeName = app.localize($ctrl.order.customer.documentTypeName);
                var mainAddress = _.find($ctrl.order.customer.addresses, function (address) {
                    return address.address.isMain;
                });
                $ctrl.order.customer.mainAddress = mainAddress.address;
            });
        };

        $ctrl.cancelOrder = function () {
            $ctrl.render.showOrders = true;
        };
    }
})();