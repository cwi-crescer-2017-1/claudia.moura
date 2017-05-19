let app = angular.module('angularjs', []);
app.controller('MainController', function($scope){

  $scope.nomes = ['Bernardo', 'Nunes'];
  $scope.incluirNome = function(novoNome){
    if($scope.form.$valid){
       $scope.nomes.push(novoNome);
    }
}

let instrutores = [
  {
    nome: 'Bernardo',
    sobrenome: 'Rezende',
    idade: 30,
    email: 'bernardo@cwi.com.br',
    jaDeuAula: true,
    aula: 'OO'
  }
];

let aulas = [
  'OO',
  'HTML e CSS',
  'Javascript',
  'AngularJS',
  'Banco de Dados I'
];

 $scope.aulas = aulas;
 $scope.instrutores = instrutores;

})
