(function () {
    var module = angular.module("GloboMartDemo");
    var ProductsController = function ($scope, productService, $log, $routeParams, $location) {
        var products = function (data) {
            $scope.products = productService.GetAllProducts();
            $log.info(data);
        };

        var singleProduct = function (data) {
            $scope.existingProduct = data;
            $log.info(data);
        };

        $scope.init = function () {
            productService.singleProduct($routeParams.productID)
                .then(singleProduct, errorDetails);
        };

        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };

        $scope.deleteProduct = function (product) {
            $log.info(product);
            productService.deleteProduct(product)
                .then(products, errorDetails);
        };

        var refresh = function () {
            productService.products()
                .then(products, errorDetails);
        };

        refresh();
        $scope.Title = "Product Details Page";
    };
    module.controller("ProductsController", ProductsController);
}());