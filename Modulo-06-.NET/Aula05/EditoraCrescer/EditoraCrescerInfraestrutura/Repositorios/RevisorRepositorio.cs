using EditoraCrescerInfraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescerInfraestrutura.Repositorios
{
    public class RevisorRepositorio
    {
        private Contexto contexto = new Contexto();
        public RevisorRepositorio()
        {

        }

        public List<Revisor> Obter()
        {
            return contexto.Revisores.ToList();
        }

        public void Inserir(Revisor revisor)
        {

            contexto.Revisores.Add(revisor);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var excluirRevisor = contexto.Revisores.FirstOrDefault(x => x.Id == id);
            contexto.Revisores.Remove(excluirRevisor);
            contexto.SaveChanges();

        }
    }
}

