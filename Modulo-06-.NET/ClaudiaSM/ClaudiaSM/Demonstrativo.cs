using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaudiaSM
{
    public class Demonstrativo
    {

            public Demonstrativo(
            double salarioBase,
            Categoria salarioCategoria,
            HorasCalculadas horasExtras,
            HorasCalculadas horasDescontadas,
            double totalProventos,
            Desconto inss,
            Desconto irrf,
            double totalDescontos,
            double totalLiquido,
            Desconto fgts)
            {
                SalarioBase = salarioBase;
                Categoria SalarioCategoria = salarioCategoria;
                HorasExtras = horasExtras;
                HorasDescontadas = horasDescontadas;
                TotalProventos = totalProventos;
                Inss = inss;
                Irrf = irrf;
                TotalDescontos = totalDescontos;
                TotalLiquido = totalLiquido;
                Fgts = fgts;
            }

            public double SalarioBase { get; private set; }
            public double SalarioCategoria { get; private set; }
            public HorasCalculadas HorasExtras { get; private set; }
            public HorasCalculadas HorasDescontadas { get; private set; }
            public double TotalProventos { get; private set; }
            public Desconto Inss { get; private set; }
            public Desconto Irrf { get; private set; }
            public double TotalDescontos { get; private set; }
            public double TotalLiquido { get; private set; }
            public Desconto Fgts { get; private set; }
        }
    }
}
