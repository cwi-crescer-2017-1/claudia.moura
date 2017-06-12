using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    class Devolucao
    {
        public int IdDevolucao { get; private set; }
        public Locacao Locacao { get; private set; }
        public DateTime? DataEntrega { get; private set; }
        public int DiasAtrasados { get; private set; }
        public double ValorPago { get; private set; }

        protected Devolucao() { }

        public Devolucao(Locacao locacao, DateTime dataEntrega, int diasAtrasados, double valorPago)
        {
            Locacao = locacao;
            DataEntrega = locacao.DataDevolucao;
            DiasAtrasados = CalcularDiasAtrasados();
            ValorPago = CalcularValorPago();
        }

       

        public double CalcularValorPago()
        {
            double  multa = Locacao.ValorDiario * DiasAtrasados * 0.1;
            return Locacao.ValorDiario * DiasAtrasados * multa;
        }
    }
}
