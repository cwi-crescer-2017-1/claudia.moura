using Locadora.Api.App_Start;
using Locadora.Api.Models;
using Locadora.Dominio.Entidades;
using Locadora.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Locadora.Api.Controllers
{
    //[BasicAuthorization]
    [RoutePrefix("api/clientes")]
    public class ClientesController : ApiController
    {
        private readonly ClienteRepositorio repositorio = new ClienteRepositorio();

        [HttpGet]
        public IHttpActionResult ObterClientes()
        {
            var clientes = repositorio.ObterClientes();
            return Ok(new { dados = clientes });
        }

        //GET api/Clientes/{cpf}
        [Route("{cpf}")]
        [HttpGet]
        public IHttpActionResult ObterUnicoCliente(string cpf)
        {
            var cliente = repositorio.ObterUnicoCliente(cpf);
            return Ok(new { dados = cliente });
        }

        [HttpPost]
        public IHttpActionResult CadastrarCliente(Cliente cliente)
        {
            var novoCliente = new Cliente(cliente.Nome, cliente.Endereco, cliente.CPF, cliente.Genero, cliente.DataNascimento);
            repositorio.CadastrarCliente(novoCliente);
            return Ok(novoCliente);
        }

        protected override void Dispose(bool disposing)
        {
            repositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}