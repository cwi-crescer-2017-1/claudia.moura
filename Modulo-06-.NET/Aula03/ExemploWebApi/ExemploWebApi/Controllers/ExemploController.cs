using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class HeroisController : ApiController
    {
        public static List<Heroi> Herois { get; set; } = new List<Heroi>();


        public int contador = 1;
        public IEnumerable<Heroi> Get(string nome = null, int? id = null)

        {
            //var herois = new List<Heroi>()
            /*{
                new Heroi() { Id = 1, Nome = "Goku", Poder = new Poder() { Nome = "Genki Dama", Dano = 8001 } },
                new Heroi() { Id = 2, Nome = "Kenshin", Poder = new Poder() { Nome = "Hiten Mitsurugi Ryu", Dano = 489 } },
                new Heroi() { Id = 3, Nome = "Madoka", Poder = new Poder() { Nome = "Deusa", Dano = 1000000 } },
            };*/
            
            return Herois.Where(heroi =>
            (heroi.Id == id || id == null) &&
            (nome == null || heroi.Nome == nome));

            /* if (id == null){ return herois;} return herois.Where(x => x.Id == id); //&& x.Nome == nome );*/
        }

        public IHttpActionResult Post(Heroi heroi)
        {
            if (heroi.Id == 0)
                return BadRequest();
            else
                Herois.Add(heroi);
                heroi.Id = contador++;
                return Ok(heroi);
        }
    }
}
