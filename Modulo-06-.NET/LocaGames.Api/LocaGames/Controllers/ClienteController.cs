using LocaGames.Dominio;
using LocaGames.Infraestrutura.Repositorios_;
using LocaGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LocaGames.Controllers
{
    [RoutePrefix("api/clientes")]
    public class ClienteController : ApiController
    {
        private readonly ClienteRepositorio repositorio = new ClienteRepositorio();

        [HttpGet]
        public IHttpActionResult ObterClientes()
        {
            var clientes = repositorio.ObterClientes();
            return Ok(clientes);
        }

        [HttpPost]
        public IHttpActionResult CadastrarCliente(ClienteModel model)
        {
            var cliente = new Cliente(model.Nome, model.Endereco, model.CPF, model.Genero, model.DataNascimento);
            repositorio.CadastrarCliente(cliente);
            return Ok(cliente);
        }

        protected override void Dispose(bool disposing)
        {
            repositorio.Dispose();
            base.Dispose(disposing);
        }
        
    }
}