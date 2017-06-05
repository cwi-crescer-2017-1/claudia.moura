using EditoraCrescerInfraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescerInfraestrutura.Repositorios
{
    public class AutorRepositorio
    {
        private Contexto contexto = new Contexto();

        public AutorRepositorio()
        {

        }

        public List<Autor> Obter()
        {
            return contexto.Autores.ToList();
        }

        public void Inserir(Autor autor)
        {
            contexto.Autores.Add(autor);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var excluirAutor = contexto.Autores.FirstOrDefault(x => x.Id == id);
            contexto.Autores.Remove(excluirAutor);
            contexto.SaveChanges();
        }
    }
}
