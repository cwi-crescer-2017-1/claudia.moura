using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Locadora.Infraestrutura.Repositorios
{
    public class LocacaoRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public List<Locacao> ObterLocacoes()
        {
            return contexto.Locacoes.ToList();
        }

        public void CadastrarLocacao(Locacao locacao)
        {
            contexto.Locacoes.Add(locacao);

            contexto.Entry(locacao.Cliente).State = EntityState.Unchanged;
            contexto.Entry(locacao.Console).State = EntityState.Unchanged;
            contexto.Entry(locacao.Pacote).State = EntityState.Unchanged;

            foreach (var opcional in locacao.Opcionais)
            {
                contexto.Entry(opcional).State = EntityState.Unchanged;
            }

            contexto.SaveChanges();
        }

        public Locacao ObterLocacaoPorId(int id)
        {
            return contexto.Locacoes.Where(x => x.IdLocacao == id)
                .Include(x => x.Cliente)
                .Include(x => x.Console)
                .Include(x => x.Pacote)
                .Include(x => x.Opcionais)
                .FirstOrDefault();
        }
        public object ObterLocacoesAtrasadas()
        {
            return contexto.Locacoes
                            .Where(x => x.DataDevolucaoReal == null && x.DataDevolucao < DateTime.UtcNow.Date)
                            .OrderBy(x => x.DataDevolucao)
                            .Select(x => new {
                                Id = x.IdLocacao,
                                Cliente = x.Cliente,
                                DiasAtraso = DbFunctions.DiffDays(x.DataDevolucao, DateTime.UtcNow)
                            }).ToList();
        }

        public object ObterLocacoesMensais(DateTime ultimoMes)
        {
            DateTime partirDe = ultimoMes.AddDays(-30);
            return contexto.Locacoes
                    .Where(x => x.DataDevolucaoReal != null && x.DataDevolucaoReal >= partirDe && x.DataDevolucaoReal <= ultimoMes)
                    .Include(x => x.Cliente)
                    .Include(x => x.IdLocacao)
                    .ToList();
        }

        public void Devolver(Locacao locacao)
        {
            contexto.Entry(locacao).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}




