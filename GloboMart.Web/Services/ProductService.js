(function () {
    var productService = function ($http, $q, $log) {
        var cachedProducts;

        var products = function () {
            if (cachedProducts)
                return $q.when(cachedProducts);

            return $http.get("http://localhost:64228/api/GetAllProducts")
                        .then(function (serviceResp) {
                            cachedProducts = serviceResp.data;
                            return serviceResp.data;
                        });
        };

        var singleProduct = function (id) {
            return $http.get("http://localhost:64228/api/GetProduct/" + id)
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };

        var insertProduct = function (product) {
            return $http.post("http://localhost:64228/api/PostProduct", product)
            .then(function (result) {
                $log.info("Insert Successful");
                cachedProducts = result.data;
                return result;
            });
        };

        var deleteProduct = function (product) {
            return $http.delete("http://localhost:64228/api/DeleteProduct/" + product.id)
            .then(function (result) {
                $log.info("Delete Successful");
                cachedProducts = result.data;
                return result.data;
            });
        };

        return {
            products: products,
            singleProduct: singleProduct,
            insertProduct: insertProduct,
            deleteProduct: deleteProduct
        };
    };

    var module = angular.module("GloboMartDemo");

    module.factory("productService", ["$http", "$q", "$log", productService]);
}());