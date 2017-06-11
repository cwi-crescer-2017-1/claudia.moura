using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class Produto
    {
        public int IdProduto { get; private set; }
        public string Console { get; private set; }
        public double ValorDiaria { get; private set; }
        public int QuantidadeProduto { get; set; }

        protected Produto() { }

        public Produto(string console, double valorDiaria, int quantidade)
        {
            Console = console;
            ValorDiaria = valorDiaria;
            QuantidadeProduto = quantidade;
            Console = console;
        }
    }
}
