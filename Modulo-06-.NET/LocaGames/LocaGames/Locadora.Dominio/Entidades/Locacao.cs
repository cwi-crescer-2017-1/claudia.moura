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
        public List<LocacaoOpcional> Opcionais { get; private set; }
        public decimal ValorDiario { get; private set; }
        public decimal ValorTotal { get; private set; }
        //public decimal TotalOpcionais { get; private set; }
        public decimal ValorPago { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataDevolucao { get; private set; }
        public DateTime DataDevolucaoReal { get; private set; }
        public int DiasAtrasados { get; private set; }
        public Cliente Cliente { get; private set; }

        protected Locacao() { }

        public Locacao(Produto console, Pacote pacote, Cliente cliente)
        {
            Console = console;
            Pacote = pacote;
            //Opcionais = new List<LocacaoOpcional>();
            Cliente = cliente;
            DataLocacao = DateTime.Now.Date;
            DataDevolucao = CalcularDataDevolucao();
            ValorDiario = CalcularValorDiario();
            ValorTotal = CalcularValorTotal();
        }

        public void SelecionarOpcional(Opcional opcional, int quantidade)
        {
            var locacaoOpcional = new LocacaoOpcional(this, opcional, quantidade);
            Opcionais.Add(locacaoOpcional);
            locacaoOpcional.Opcional.DiminuirEstoque(locacaoOpcional.Quantidade);
            //TotalOpcionais += locacaoOpcional.Opcional.ValorDiaria;
        }

        private decimal CalcularValorDiario()
        {
            return ValorDiario = (ValorDiario + Console.ValorDiaria) * Pacote.DescontoPacote;           
        }

        private decimal  CalcularValorTotal()
        {          
            return ValorDiario * Pacote.QuantidadeDias * Pacote.DescontoPacote;
        }

        public DateTime CalcularDataDevolucao()
        {
            return DataDevolucao = DataLocacao.Date.AddDays(Pacote.QuantidadeDias);
        }

        public int CalcularDiasAtrasados()
        {
            return DiasAtrasados = Convert.ToInt32(DataDevolucaoReal - DataDevolucao);
        }

        public decimal CalcularValorPago()
        {
            decimal multa = ValorDiario * DiasAtrasados * 0.1m;
            return ValorTotal + (ValorDiario * DiasAtrasados) + multa;
        }
    }
}
