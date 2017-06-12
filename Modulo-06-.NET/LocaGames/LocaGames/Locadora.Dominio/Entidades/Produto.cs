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
        public decimal ValorDiaria { get; private set; }
        public int QuantidadeProduto { get; set; }

        protected Produto() { }

        public Produto(string console, decimal valorDiaria, int quantidade)
        {
            Console = console;
            ValorDiaria = valorDiaria;
            QuantidadeProduto = quantidade;
            Console = console;
        }

        public void DiminuirEstoque(int quantidade)
        {
            QuantidadeProduto -= quantidade;
        }

        public void AumentarEstoque(int quantidade)
        {
            QuantidadeProduto += quantidade;
        }
    }
}
