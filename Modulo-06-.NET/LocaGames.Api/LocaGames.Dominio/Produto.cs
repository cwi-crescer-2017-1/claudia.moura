using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Produto
    {
        public int IdProduto { get; private set; }
        public string Console { get; private set; }
        public double ValorDiaria { get; private set; }
        public int Quantidade { get; private set; }

        protected Produto() { }

        public Produto(string console, double valorDiaria, int quantidade)
        {
            Console = console;
            ValorDiaria = valorDiaria;
            Quantidade = quantidade;
            Console = console;
        }
    }

}
