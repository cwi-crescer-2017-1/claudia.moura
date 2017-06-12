using Locadora.Api.Models;
using Locadora.Infraestrutura.Repositorios;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Locadora.Api.App_Start;

namespace Locadora.Api.Controllers
{
    //[BasicAuthorization]
    [RoutePrefix("api/Locacoes")]
    public class LocacoesController : ApiController
    {
        private LocacaoRepositorio repositorioLocacao = new LocacaoRepositorio();
        private ClienteRepositorio repositorioCliente = new ClienteRepositorio();
        private ProdutoRepositorio repositorioProduto = new ProdutoRepositorio();
        private PacoteRepositorio repositorioPacote = new PacoteRepositorio();
        private OpcionalRepositorio repositorioOpcionais = new OpcionalRepositorio();

        //GET api/Locacoes
        [HttpGet]
        public IHttpActionResult ObterLocacoes()
        {
            var locacoes = repositorioLocacao.ObterLocacoes();
            return Ok(new { dados = locacoes });
        }

        //GET api/Locacoes
        [HttpGet]
        [Route("atrasadas")]
        public IHttpActionResult ObterLocacoesAtrasadas()
        {
            var locacoesAtrasadas = repositorioLocacao.ObterLocacoesAtrasadas();
            return Ok(new { dados = locacoesAtrasadas });
        }

        [HttpGet]
        //[BasicAuthorization(Roles = "Gerente")]
        [Route("{dataFiltro}")]
        public IHttpActionResult ObterLocacoesMensais(DateTime dataFiltro)
        {
            var locacoesMensais = repositorioLocacao.ObterLocacoesMensais(dataFiltro);
            return Ok(new { dados = locacoesMensais });
        }

        //POST api/Locacoes 
        [HttpPost]
        public IHttpActionResult IncluirLocacao(LocacaoModel locacaoModel)
        {
            var cliente = locacaoModel.Cliente;
            var produto = locacaoModel.Produto;
            var pacote = locacaoModel.Pacote;

            var locacao = new Locacao(produto, pacote, cliente);
            repositorioLocacao.CadastrarLocacao(locacao);

            repositorioProduto.DiminuirEstoque(produto.IdProduto);
           // repositorioOpcionais.DiminuirEstoque(locacaoModel.Opcionais);

            return Ok(locacao);
        }

        /*//devolucao
        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult DevolverLocacao(int id)
        {
            var locacao = repositorioLocacao.ObterLocacaoPorId(id);

            locacao.Devolver();
            repositorioProduto.AumentarEstoque(locacao.Produto.Id);
            repositorioOpcionais.AumentarEstoque(locacao.Opcionais);
            repositorioOpcionais.AumentarEstoque(locacao.Pacote.Opcionais);

            repositorioLocacao.Editar(locacao);
            return Ok(locacao);
        }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                repositorioLocacao.Dispose();
            repositorioCliente.Dispose();
            repositorioProduto.Dispose();
            repositorioPacote.Dispose();
            repositorioOpcionais.Dispose();
            base.Dispose(disposing);
        }

    }
}