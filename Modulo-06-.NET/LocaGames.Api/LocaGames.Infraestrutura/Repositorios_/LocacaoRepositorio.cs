using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    public class LocacaoRepositorio : IDisposable
    {

        private Contexto contexto = new Contexto();

        public List<Locacao> Obter()
        {
            return contexto.Locacao.ToList();
        }

        public void CadastrarLocacao(Locacao locacao)
        {
            contexto.Locacao.Add(locacao);
            contexto.SaveChanges();
        }

        public Locacao ObterLocacao(int id)
        {
            return contexto.Locacao.FirstOrDefault(l => l.IdLocacao == id);
        }

        public List<Cliente> ObterClientesComLocacoesAtrasadas()
        {
            return contexto.Locacao
                .Include("Cliente")
                .Where(l => l.DataEntregaReal == null && l.DataEntregaPrevista < DateTime.Now)
                .Select(l => l.Cliente)
                .ToList();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
