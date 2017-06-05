using EditoraCrescerInfraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescerInfraestrutura.Repositorios
{
    public class LivroRepositorio
    {
        private Contexto contexto = new Contexto();
        public LivroRepositorio()
        {

        }

        public List<Livro> Obter()
        {
            return contexto.Livros.ToList();
        }

        public void Inserir(Livro livro)
        {
            contexto.Livros.Add(livro);
            contexto.SaveChanges();
        }

        public void Excluir(int isbn)
        {
            var excluirLivro = contexto.Livros.FirstOrDefault(x => x.Isbn == isbn);
            contexto.Livros.Remove(excluirLivro);
            contexto.SaveChanges();
        }
    }
}
