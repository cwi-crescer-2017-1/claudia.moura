using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Repositorios_
{
    public class FuncionarioRepositorio : IDisposable
    {
        Contexto contexto = new Contexto();

        public FuncionarioRepositorio()
        {

        }

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            contexto.Funcionarios.Add(funcionario);
            contexto.SaveChanges();
        }

        public Funcionario ObterFuncionario(string email)
        {
            return contexto.Funcionarios
                .FirstOrDefault(f => f.Email == email);
        }
        
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
