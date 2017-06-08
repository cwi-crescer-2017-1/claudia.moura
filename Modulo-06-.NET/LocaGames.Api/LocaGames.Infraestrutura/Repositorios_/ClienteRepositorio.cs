using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    public class ClienteRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();
        

        public List<Cliente> ObterClientes()
        {
            return contexto.Clientes.ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            return contexto.Clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public Cliente BuscarPorCPF(string cpf)
        {
            return contexto.Clientes
                .FirstOrDefault(c => c.CPF == cpf);
        }

        public void CadastrarCliente(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        /*public Cliente AtualizarCliente(Cliente cliente)
        {
            contexto.Entry(cliente).State = EntityState.Modified;
            contexto.SaveChanges();
        }*/



    }
}

