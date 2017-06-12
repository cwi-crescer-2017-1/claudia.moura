modulo.factory('locacaoService', function($http) {  
    let urlLocacao = 'http://localhost:55732/api/locacoes'; 
    let urlProduto = 'http://localhost:55732/api/produtos';
    let urlPacote = 'http://localhost:55732/api/pacotes';
    let urlCliente = 'http://localhost:55732/api/Clientes';
    let urlOpcionais = 'http://localhost:55732/api/opcionais';

    function buscarProdutos() {
        return $http.get(`${urlProduto}`);
    }

    function buscarPacotes() {
        return $http.get(`${urlPacote}`);
    }

     function buscarClientes() {
        return $http.get(`${urlCliente}`);
    }

    function buscarAdicionais() {
        return $http.get(`${urlItens}`);
    }
    
    function salvar(locacao) {
        console.log(locacao);
        return $http.post(`${urlLocacao}`,locacao);
    }

     return{
         buscarProdutos: buscarProdutos,
         buscarPacotes : buscarPacotes,
         buscarClientes : buscarClientes,
         buscarAdicionais: buscarAdicionais,
         salvar : salvar
    };
})