using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infraestrutura.Repositorios
{
    public class ClienteRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public List<Cliente> ObterClientes()
        {
            return contexto.Clientes.ToList();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            var excluir = contexto.Clientes.FirstOrDefault(x => x.IdCliente == id);
            contexto.Clientes.Remove(excluir);
            contexto.SaveChanges();
        }

        public Cliente ObterUnicoCliente(string cpf)
        {
            return contexto.Clientes.Where(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterClientePorNome(string nomeCompleto)
        {
            return contexto.Clientes.Where(x => x.Nome == nomeCompleto).FirstOrDefault();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
