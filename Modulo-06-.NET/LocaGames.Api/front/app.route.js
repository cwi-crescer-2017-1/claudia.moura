angular.module('app').config(function ($routeProvider) {

  .when('/login', {
    controller: 'LoginController',
    templateUrl: 'login/login.html'
    })
    
    .when('/Cliente', {
    controller: 'ClienteController',
    templateUrl: 'Cliente/Cliente.html',
    resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }
     })

    .otherwise('/home');
});
