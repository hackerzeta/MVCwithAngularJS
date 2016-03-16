

(function () {
    
    var app = angular.module('MyApp', ['ng-Route']);

    app.controller('HomeController', function ($scope) {
        $scope.Message = "Hola";
    });

});