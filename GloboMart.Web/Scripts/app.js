(function () {
    var app = angular.module("GloboMartDemo", ["ngRoute"]);

    app.config(function ($routeProvider) {
        $routeProvider
          .when("/index", {
              templateUrl: "ProductDetails.html",
              controller: "ProductController"
          })
          .otherwise({
              redirectTo: "/index"
          });
    });

}());