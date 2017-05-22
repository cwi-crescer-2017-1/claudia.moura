var modulo = angular.module('angularjs',[]);
modulo.controller('controller', function($scope,$filter){

	aulas = [
	  {id: 0, nome: 'Orientação a objetos', emAndamento: false},
	  {id: 1, nome: 'Banco de Dados', emAndamento: false},
	  {id: 2, nome: 'HTML/CSS', emAndamento: false},
	  {id: 3, nome: 'Javascript', emAndamento: false},
	  {id: 4, nome: 'AngularJS', emAndamento: true}
	];//fim aulas

	$scope.aulas = aulas;

	$scope.adicionarAula = function(){
		novaAula = {
			id: aulas.length,
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
});//fim módulo
