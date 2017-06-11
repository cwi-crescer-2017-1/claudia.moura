var modulo = angular.module('app', ['ngRoute']);

modulo.config(function($routeProvider) {
    $routeProvider
    
    .when('/cliente', {
      controller: 'clienteController',
      templateUrl: 'front/cliente/cliente.html',
      /*resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }*/
      
    })/*
    .when('/locacao', {
      controller: 'locacaoController',
      templateUrl: 'locacao/locacao.html',
      resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }
    })
    .when('/relatorio', {
      controller: 'relatorioController',
      templateUrl: 'relatorio/relatorio.html',
      resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }
    })
    .when('/devolucao', {
      controller: 'devolucaoController',
      templateUrl: 'devolucao/devolucao.html',
      resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }
    })
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })*/
    .otherwise({redirectTo: '/cliente'});
});