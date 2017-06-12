using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class OpcionalRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public List<Opcional> Obter()
        {
            return contexto.Opcionais.ToList();
        }
       
        public Opcional ObterPorId(int id)
        {
            return contexto.Opcionais.Where(x => x.IdOpcional == id).FirstOrDefault();
        }

        public Opcional ObterPorNome(string nome)
        {
            return contexto.Opcionais.Where(x => x.Nome == nome).FirstOrDefault();
        }

        public void DiminuirEstoque(int id)
        {
            var produto = contexto.Opcionais.Where(x => x.IdOpcional == id).FirstOrDefault();
            --produto.QuantidadeTotal;
            contexto.SaveChanges();
            return;
        }

        public void AumentarEstoque(int id)
        {
            var produto = contexto.Opcionais.Where(x => x.IdOpcional == id).FirstOrDefault();
            ++produto.QuantidadeTotal;
            contexto.SaveChanges();
            return;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }        
    }
}