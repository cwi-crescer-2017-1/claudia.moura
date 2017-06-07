using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Locacao
    {
        public int IdLocacao { get; private set; }
        public Produto Console { get; private set; }
        public Pacote Pacote { get; private set; }
        public List<LocacaoOpcional> Opcionais { get; private set; }
        public double ValorTotal { get; private set; }
        public DateTime? Data { get; private set; }
        public Cliente Cliente { get; private set; }

        protected Locacao() { }

        public Locacao(Produto console, Pacote pacote, Cliente cliente)
        {
            Console = console;
            Pacote = pacote;
            Opcionais = new List<LocacaoOpcional>();
            Cliente = cliente;
        }

        public void InserirOpcional(Opcional opcional, int qtd)
        {
            Opcionais.Add(new LocacaoOpcional(this, opcional, qtd));
            ValorTotal += opcional.ValorDiaria;
        }

    }
}

