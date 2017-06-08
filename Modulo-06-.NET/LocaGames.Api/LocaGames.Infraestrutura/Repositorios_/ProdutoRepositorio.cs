using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    class ProdutoRepositorio : IDisposable
    {

        private Contexto contexto = new Contexto();

        public List<Produto> Obter()
        {
            return contexto.Produtos.ToList();
        }

        public Produto ObterProduto(int id)
        {
            return contexto.Produtos.FirstOrDefault(p => p.IdProduto == id);
        }

        public Produto AtualizarQuantidade(Produto produto)
        {
            contexto.Entry(produto).State = EntityState.Modified;
            produto.Quantidade--;
            contexto.SaveChanges();
            return produto;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }   
}
