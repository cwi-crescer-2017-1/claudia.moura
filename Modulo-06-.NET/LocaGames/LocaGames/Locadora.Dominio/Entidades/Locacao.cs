using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class Locacao
    {
        public int IdLocacao { get; private set; }
        public Produto Console { get; private set; }
        public Pacote Pacote { get; private set; }
        public List<Opcional> Opcionais { get; private set; }
        public double ValorTotal { get; private set; }
        public DateTime? Data { get; private set; }
        public Cliente Cliente { get; private set; }

        protected Locacao() { }

        public Locacao(Produto console, Pacote pacote, Cliente cliente, List<Opcional> opcionais)
        {
            Console = console;
            Pacote = pacote;
            Opcionais = opcionais;
            Cliente = cliente;
            ValorTotal = CalcularValorTotal();
        }

        private double CalcularValorTotal()
        {
            double valorProduto = Console.ValorDiaria * Pacote.QuantidadeDias;
            double valorOpcional = Opcionais.Sum(x => x.ValorDiaria) * Pacote.QuantidadeDias;
            return valorProduto + valorOpcional * Pacote.ValorPacote;
        }



    }
}
