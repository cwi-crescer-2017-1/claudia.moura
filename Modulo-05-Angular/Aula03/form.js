let app = angular.module('angularjs', []);
app.controller('MainController', function($scope){

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


  $scope.adicionarInstrutor = function(){
    novoInstrutor = {
      nome:$scope.novoInstrutor.nome,
      sobrenome:$scope.novoInstrutor.sobrenome,
      idade:$scope.novoInstrutor.idade,
      email:$scope.novoInstrutor.email,
      jaDeuAula:$scope.novoInstrutor.jaDeuAula || false,
      aula:$scope.novoInstrutor.aula
    };
    $scope.instrutores.push(novoInstrutor);
    alert('Cadastro efetivado com sucesso!')
  };

})
