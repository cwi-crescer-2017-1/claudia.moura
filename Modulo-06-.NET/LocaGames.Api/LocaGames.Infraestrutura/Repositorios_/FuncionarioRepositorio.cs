using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    public class FuncionarioRepositorio : IDisposable
    {
        private Contexto contexto = new Contexto();

        public void Criar(Funcionario funcionario)
        {
            contexto.Funcionarios.Add(funcionario);
            contexto.SaveChanges();
        }

        public Funcionario Obter(string email)
        {
            return contexto.Funcionarios.Where(u => u.Email == email)
                .Include(a => a.Permissoes)
                .FirstOrDefault();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
