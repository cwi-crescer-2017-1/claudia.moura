using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Opcional
    {
        public int Id { get; private set; }
        public string Tipo { get; private set; }
        public Produto Console { get; private set; }
        public double ValorDiaria { get; private set; }
        public int QuantidadeTotal { get; private set; }
    }
}
