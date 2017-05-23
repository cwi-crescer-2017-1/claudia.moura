let app = angular.module('app', ['ngRoute']);

app.config(function ($routeProvider) {

  $routeProvider
    .when('/home', {
      controller: 'HomeController',
      templateUrl: 'home.html'
    })
    .when('/aulas', {
      controller: 'AulasController',
      templateUrl: 'aulas.html'
    })
    .when('/instrutores', {
      controller: 'InstrutoresController',
      templateUrl: 'instrutores.html'
    })
    .otherwise({
      redirectTo: '/home'
    });
});

app.controller('HomeController', function ($scope) {
  $scope.controller = 'HomeController';
});

app.controller('AulasController', function ($scope) {
  $scope.controller = 'AulasController';
});

app.controller('InstrutoresController', function ($scope) {
  $scope.controller = 'InstrutoresController';
});
