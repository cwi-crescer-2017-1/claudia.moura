angular.module('app').factory('instrutorService', function ($http) {

  let urlBase = 'http://localhost:3000/instrutor';

  function listarInstrutores() {
    return $http.get(urlBase);
  };

  function buscarPorId(id) {
    return $http.get(urlBase + '/' + id);
  };

  function alterar(instrutor) {
    return $http.put(urlBase + '/' + instrutor.id, instrutor);
  };
  
  function incluir(instrutor) {
    return $http.post(urlBase, instrutor);
  };

  function excluir(instrutor) {
    return $http.delete(urlBase + '/' + instrutor.id);
  };

  return {

    listar: listarInstrutores,
    alterar: alterar,
    incluir: incluir,
    excluir: excluir,
    buscarPorId: buscarPorId
  };
})