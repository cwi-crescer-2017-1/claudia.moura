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
    public class AutoresController : ApiController
    {
        //private Contexto contexto = new Contexto();

        private AutorRepositorio repositorio = new AutorRepositorio();

        public IHttpActionResult Get()
        {
            var autores = repositorio.Obter();
            return Ok(autores);
        }

        public IHttpActionResult Post(Autor autor)
        {
            repositorio.Inserir(autor);
            return Ok(autor);

        }

        public IHttpActionResult Delete(int id)
        {
            repositorio.Excluir(id);
            return Ok();
        }
    }
}
