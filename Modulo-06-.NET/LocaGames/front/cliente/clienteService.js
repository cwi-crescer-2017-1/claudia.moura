modulo.factory('clienteService', function($http) {
    
    let urlbase = 'http://localhost:55732/api/Clientes';

    function salvar(cliente) {
        return $http.post(urlbase, cliente);
    }
      return{
        salvar: salvar
    };
})