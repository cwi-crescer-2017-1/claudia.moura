using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaudiaSM
{
    public class Desconto
    {
        public Desconto(double aliquota, double valor)
        {
            Aliquota = aliquota;
            Valor = valor;
        }

        public double Aliquota { get; private set; }
        public double Valor { get; private set; }


        public double CalculaINSS(double TotalProventos)
        {
            var aliquota = 0;
            if (TotalProventos <= 1000)
                aliquota = 8;
            else if (TotalProventos <= 1500)
                aliquota = 9;
            else
                aliquota = 10;
            double INSS = (Math.Round((TotalProventos * aliquota / 100), 2));
            return INSS;
        }

        public double CalculaIRRF(double totalProventos, double inss)
        {
            double aliquota = 0;
            double valor = (totalProventos - CalculaINSS(totalProventos));
            if (valor <= 1710.78)
                return 0;
            else if (valor <= 2563.91)
                aliquota = 7.5;
            else if (valor <= 3418.59)
                aliquota = 15;
            else if (valor <= 4271.59)
                aliquota = 22.5;
            else
                aliquota = 27.5;
            double IRRF = (Math.Round(valor * aliquota / 100));
            return IRRF;
        }
    }
}