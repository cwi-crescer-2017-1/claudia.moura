using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class Cliente
    {

        public int IdCliente { get;  set; }
        public string Nome { get;  set; }
        public string Endereco { get;  set; }
        public string CPF { get;  set; }
        public string Genero { get;  set; }
        public DateTime DataNascimento { get;  set; }

        protected Cliente() { }

        public Cliente(string nome, string endereco, string cpf, string genero, DateTime dataNascimento)
        {
            Nome = nome;
            Endereco = endereco;
            CPF = cpf;
            Genero = genero;
            DataNascimento = dataNascimento;
        }
    }
}
