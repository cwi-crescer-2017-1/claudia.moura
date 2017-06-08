using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    class PacoteRepositorio : IDisposable
    {

        private Contexto contexto = new Contexto();

        public List<Pacote> Obter()
        {
            return contexto.Pacotes.ToList();
        }

        public Pacote ObterPacote(int id)
        {
            return contexto.Pacotes.FirstOrDefault(i => i.IdPacote == id);
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
