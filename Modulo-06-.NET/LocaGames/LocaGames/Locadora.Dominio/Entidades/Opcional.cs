using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class Opcional 
    {

        public int IdOpcional { get; private set; }
        public string Nome { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public int QuantidadeTotal { get; set; }

        protected Opcional() { }

        public Opcional(string nome, decimal valorDiaria, int quantidadeTotal)
        {
            Nome = nome;
            ValorDiaria = valorDiaria;
            QuantidadeTotal = quantidadeTotal;            
        }

        public void DiminuirEstoque(int quantidade)
        {
            QuantidadeTotal -= quantidade;
        }

        public void AumentarEstoque(int quantidade)
        {
            QuantidadeTotal += quantidade;
        }
    }
}
