var modulo = angular.module("angularjs", []);


/*
modulo.filter('ordem', function(){
	return function(lista){
	lista.sort(function(a, b) { parseFloat(a.aula[0]) - parseFloat(b.aula[0]);
		return 
	});
}
});*/


modulo.filter()


modulo.filter('maiuscula',function(){
  return function(nome){
    return nome.replace(nome, nome.toUpperCase());
  }
});

modulo.filter('let3',function(){
  return function(nome){
    return "00" + nome.substr(-2,2)
  }
});

modulo.filter('let3',function(){
  return function(nome){
    return "00" + nome.substr(-2,2)
  }
});

modulo.controller("instrutores", function($scope, $filter) {
  $scope.instrutores = [{
    nome: 'Pedro (PHP)',
    aula: [{
      numero: 3,
      nome: 'HTML e CSS'
    }]
  },
  {
    nome: 'Zanatta',
    aula: [{
      numero: 5,
      nome: 'AngularJS'
    }]
  },
  {
    nome: 'Bernardo',
    aula: [{
        numero: 1,
        nome: 'OO'
      },
      {
        numero: 4,
        nome: 'Javascript'
      }
    ]
  },
  {
    nome: 'Nunes',
    aula: [{
      numero: 2,
      nome: 'Banco de Dados I'
    }]
  }
];

});
