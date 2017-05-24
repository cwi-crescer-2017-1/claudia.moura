angular.module('app').controller('InstrutorController', function ($scope, instrutorService, $location, toastr) {

    $scope.editar = editar;
    $scope.salvar = salvar;
    $scope.excluir = excluir;

    carregarInstrutores();

    // Funções internas

    function editar(instrutor) {
      $scope.novoInstrutor = angular.copy(instrutor);
    }
instrutor
    function salvar(instrutor) {
      if ($scope.formInstrutor.$invalid) {
        return;
      }

      let promise = {};

      if (angular.isDefined(instrutor.id)) {
        promise = instrutorService.alterar(instrutor);

      } else {
        promise = instrutorService.incluir(instrutor)
      }

      promise.then(function (response) {
        carregarInstrutores();
        toastr.success('Sucesso!', '', { closeButton: true })
      });

      $scope.novoInstrutor = {};
    }

    function excluir(instrutor) {
      let promise = instrutorService.excluir(instrutor);

      promise.then(function (response) {
        carregarInstrutores();
      });
    }

    function carregarInstrutores() {
      let promessa = instrutorService.listar();

      promessa.then(function (response) {
        $scope.instrutores = response.data;
      })
    };


    $scope.adicionarInstrutor = function(){
    novoInstrutor = {
      nome:$scope.nomeInstrutor,
      sobrenome:$scope.sobrenomeInstrutor,
      idade:$scope.idadeInstrutor,
      email:$scope.emailInstrutor,
      lecionando:$scope.estaDandoAula || false,
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
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].nome = $scope.nomeInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].nomeInstrutor;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].sobrenome = $scope.sobrenomeInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].sobrenomeInstrutor;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].idade = $scope.idadeInstrutorModificada || $scope.instrutores[$scope.selecionaModificarInstrutor.id].idade;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].email = $scope.emailInstrutorModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].email;
      $scope.instrutores[$scope.selecionaModificarInstrutor.id].lecionando = $scope.estaDandoAulaModificado || $scope.instrutores[$scope.selecionaModificarInstrutor.id].lecionando;
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

  });
