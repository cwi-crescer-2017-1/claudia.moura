var modulo = angular.module('angularjs',[]);
modulo.controller('controller', function($scope,$filter){

	let aulas = [
  {id: 0, nome: 'Orientação a objetos', emAndamento: false},
  {id: 1, nome: 'Banco de Dados'},
  {id: 2, nome: 'HTML/CSS'},
  {id: 3, nome: 'Javascript'},
  {id: 4, nome: 'AngularJS'}
];//fim aulas

	$scope.aulas = aulas;
	$scope.idAulas = 1;

	$scope.adicionarAula = function(){
		novaAula = {
			id:$scope.idAulas++,
			nome:$scope.novaAula,
			emAndamento:$scope.aulaEmAndamento || false,
		}; //fim novaAula
		for (var i = 0; i < $scope.aulas.length; i++) {
      if($scope.aulas[i].nome.toLowerCase() === $scope.novaAula.toLowerCase()) {
      	return alert('Aula já cadastrada.'); 
      }//fim if
    };//fim for
		$scope.aulas.push(novaAula);
		return alert('Cadastro efetivado com sucesso!');
	}//fim adicionarAula
$scope.aulas = aulas;

	$scope.alterarAula = function() {
		for (var i = 0; i < $scope.aulas.length; i++) {
      if($scope.aulas[i].nome.toLowerCase() === $scope.nomeModificar.toLowerCase()) {
      	return alert('Aula já cadastrada.'); 
      }//fim if
    };//fim for
		$scope.aulas[$scope.selecionaModificar.id]. nome = $scope.nomeModificar; 		
		return alert('Aula alterada com sucesso.')
	}

	$scope.excluirAula = function() {
		if($scope.aulas[$scope.selecionaExcluir.id].emAndamento){
			return alert('Não é possível excluir esta aula. Está sendo utilizada.')
		}
		$scope.aulas.splice($scope.selecionaExcluir.id, 1); 		
		return alert('Aula excluida com sucesso.')
	}

	let instrutores = [
  {
    id: 0,
    nome: 'Bernardo',
    sobrenome: 'Rezende',
    idade: 29,
    email: 'bernardo@cwi.com.br',
    lecionando: true,
    aula: [aulas[0], aulas[3]],
    urlFoto: 'https://avatars0.githubusercontent.com/u/526075?v=3&s=460'
  },
  {
    id: 1,
    nome: 'André',
    sobrenome: 'Nunes',
    idade: 31,
    email: 'nunes@cwi.com.br',
    lecionando: false,
    aula: [aulas[1]],
    urlFoto: 'https://avatars2.githubusercontent.com/u/10319453?v=3&s=460'
  },
  {
    id: 2,
    nome: 'Pedro Henrique',
    sobrenome: 'Pires',
    idade: 23,
    email: 'php@cwi.com.br',
    lecionando: false,
    aula: [aulas[2]],
    urlFoto: 'https://avatars0.githubusercontent.com/u/6934800?v=3&s=460'
  },
  {
    id: 3,
    nome: 'Everton',
    sobrenome: 'Zanatta',
    idade: 25,
    email: 'zanatta@cwi.com.br',
    lecionando: true,
    aula: [aulas[4]],
    urlFoto: 'https://avatars2.githubusercontent.com/u/4175351?v=3&s=460'
}]; //fim instrutores

$scope.instrutores = instrutores;
$scope.idInstrutor = 0;

$scope.adicionarInstrutor = function(){
    novoInstrutor = {
    	id:$scope.idInstrutor++,
      nome:$scope.nomeInstrutor,
      sobrenome:$scope.sobrenomeInstrutor,
      idade:$scope.idadeInstrutor,
      email:$scope.emailInstrutor,
      lecionando:$scope.estaDandoAula || false,
      //aula:$scope.novoInstrutor.aula,
      urlFoto: $scope.urlFotoInstrutor || 'https://codeclubprojects.org/en-GB/webdev/pixel-art/images/pixel-art-black-example.png'
    };
    for (var i = 0; i < $scope.instrutores.length; i++) {
      if($scope.instrutores[i].nome.toLowerCase() === $scope.nomeInstrutor.toLowerCase()) {
      	return alert('Professor já cadastrado.');
      }else if($scope.idadeInstrutor > 90){
      	return(alert('Idade inválida.'))
      }else if($scope.instrutores[i].email.toLowerCase() === $scope.emailInstrutor.toLowerCase()){
      	return alert('Email já cadastrado.')
      }//fim if
    };//fim for

    $scope.instrutores.push(novoInstrutor);
    alert('Cadastro efetivado com sucesso!')
  };




    $scope.modificarInstrutor = function(){
      /*if(($scope.nomeInstrutorModificado !== 'undefined') ||
      	($scope.instrutores[$scope.selecionaModificarInstrutor.id].nome.toLowerCase()) === $scope.nomeInstrutorModificado.toLowerCase()) {
        return alert('Professor já cadastrado.');
      }else if(($scope.idadeInstrutorModificada !== 'undefined') ||($scope.idadeInstrutorModificada > 90)){
      	return(alert('Idade inválida.'))
      }
      for (var i = 0; i < $scope.instrutores.length; i++) {
	      if(( typeof $scope.emailInstrutorModificado !== 'undefined') || 
	      ($scope.instrutores[i].email.toLowerCase() === $scope.emailInstrutorModificado.toLowerCase()) && ($scope.selecionaModificarInstrutor.id !== i)){
	      	return alert('Email já cadastrado.')
      	}//fim if
    	};//fim for*/

      $scope.instrutores[$scope.selecionaModificarInstrutor.id].nome = $scope.nomeInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].nomeInstrutor;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].sobrenome = $scope.sobrenomeInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].sobrenomeInstrutor;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].idade = $scope.idadeInstrutorModificada || $scope.instrutores[$scope.selecionaModificarInstrutor.id].idade;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].email = $scope.emailInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].email;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].lecionando = $scope.estaDandoAulaModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].lecionando;
      //aula:$scope.novoInstrutor.aula,
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].urlFoto = $scope.urlFotoInstrutorModificado || 'https://codeclubprojects.org/en-GB/webdev/pixel-art/images/pixel-art-black-example.png'
    
    alert('Instrutor modificado com sucesso!')
  };

  $scope.excluirInstrutor = function() {
		if($scope.instrutores[$scope.selecionaExcluirInstrutor.id].lecionando){
			return alert('Não é possível excluir este instrutor. Está dando aula.')
		}
		$scope.instrutores.splice($scope.selecionaExcluirInstrutor.id, 1); 		
		return alert('Instrutor excluido com sucesso.')
	}

});//fim módulo
