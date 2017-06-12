using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class Pacote
    {
        public int IdPacote { get; private set; }
        public string Nome { get; private set; }
        public decimal DescontoPacote { get; private set; }
        public int QuantidadeDias { get; private set; }

        protected Pacote() { }

        public Pacote(string nome, decimal valor, int qtdeDias)
        {
            Nome = nome;
            DescontoPacote = valor;
            QuantidadeDias = qtdeDias;
        }        
    }
}
