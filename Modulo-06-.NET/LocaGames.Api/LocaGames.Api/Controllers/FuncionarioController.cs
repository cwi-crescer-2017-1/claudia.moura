using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LocaGames.Dominio;
using LocaGames.Infraestrutura.Repositorios_;
using LocaGames.Models;
using System.Threading;

namespace LocaGames.Controllers 
{
    [AllowAnonymous]
    [RoutePrefix("Api/Acessos")]
    public class FuncionarioController : ApiController
    {
        readonly FuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController()
        {
            _funcionarioRepositorio = new FuncionarioRepositorio();
        }

        [HttpGet, Route("usuario")]

       // [BasicAuthorization]

        public IHttpActionResult Obter()
        {
            var usuarioDaSessao = _funcionarioRepositorio.Obter(Thread.CurrentPrincipal.Identity.Name);

            if (usuarioDaSessao == null)
            {
                return BadRequest("Usuario não encontrado");
            }
            var usuario = new { Email = usuarioDaSessao.Email, Permissoes = usuarioDaSessao.Permissoes };
            return Ok(new { dados = usuario });
        }
    }
}