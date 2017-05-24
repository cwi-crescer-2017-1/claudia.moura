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


  });
