﻿using EditoraCrescerInfraestrutura;
using EditoraCrescerInfraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EditoraCrescer.API.Controllers
{
    public class LivrosController : ApiController
    {
        //private Contexto contexto = new Contexto();

        private LivroRepositorio repositorio = new LivroRepositorio();

        public IHttpActionResult Get()
        {
            var livros = repositorio.Obter();
            return Ok(livros);
        }
    }
}
