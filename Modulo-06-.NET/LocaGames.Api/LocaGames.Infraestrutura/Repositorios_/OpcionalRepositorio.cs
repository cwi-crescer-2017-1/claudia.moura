using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    public class OpcionalRepositorio : IDisposable
    {

        private Contexto contexto = new Contexto();

        public List<Opcional> Obter()
        {
            return contexto.Opcionais.ToList();
        }

        public Opcional ObterOpcional(int id)
        {
            return contexto.Opcionais.FirstOrDefault(l => l.IdOpcional == id);
        }

        public Opcional AtualizarQuantidade(Opcional opcional)
        {
            contexto.Entry(opcional).State = EntityState.Modified;
            opcional.QuantidadeTotal--;
            contexto.SaveChanges();
            return opcional;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
