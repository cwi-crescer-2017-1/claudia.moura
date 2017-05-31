using EditoraCrescerInfraestrutura;
using EditoraCrescerInfraestrutura.Entidades;
using EditoraCrescerInfraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EditoraCrescer.API.Controllers
{
    public class RevisoresController : ApiController
    {
        private Contexto contexto = new Contexto();

        private RevisorRepositorio repositorioRevisor = new RevisorRepositorio();

        public IHttpActionResult Get()
        {
            var revisor = repositorioRevisor.Obter();
            return Ok(revisor);
        }

        public IHttpActionResult Post(Revisor revisor)
        {
            repositorioRevisor.Inserir(revisor);
            return Ok(revisor);

        }

        public IHttpActionResult Delete(int id)
        {
            repositorioRevisor.Excluir(id);
            return Ok();
        }
    }
}
