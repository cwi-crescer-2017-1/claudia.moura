var modulo = angular.module('app', ['ngRoute','auth']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/locacao', {
      controller: 'locacaoController',
      templateUrl: 'front/locacao/locacao.html',
      /*resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }*/
    })
    .when('/cliente', {
      controller: 'clienteController',
      templateUrl: 'front/cliente/cliente.html',
      /*resolve: {
        autenticado: function (authService) {
          return authService.isAutenticadoPromise();
        }
      }*/
      
    })/*
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
    })*/
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })
    .otherwise({redirectTo: '/cliente'});
});