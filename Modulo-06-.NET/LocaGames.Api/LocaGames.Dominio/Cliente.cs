using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string CPF { get; private set; }
        public string Genero { get; private set; }
        public DateTime? DataNascimento { get; private set; }

        protected Cliente() { }

        public Cliente(string nome, string endereco, string cidade, string cpf, string genero, DateTime dataNascimento)
        {
            Nome = nome;
            Endereco = endereco;            
            CPF = cpf;
            Genero = genero;
            DataNascimento = dataNascimento;
        }
    }
}
