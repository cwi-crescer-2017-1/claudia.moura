using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.Entidades
{
    public class LocacaoOpcional
    {
        public int IdLocacaoOpcional { get; private set; }
        public Locacao Locacao { get; private set; }
        public Opcional Opcional { get; private set; }
        public int Quantidade { get; private set; }

        protected LocacaoOpcional() { }

        public LocacaoOpcional(Locacao locacao, Opcional opcional, int quantidade)
        {
            Locacao = locacao;
            Opcional = opcional;
            Quantidade = quantidade;
        }
    }
}
