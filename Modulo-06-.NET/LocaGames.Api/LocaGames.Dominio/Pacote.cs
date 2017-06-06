using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Pacote
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public Produto Console { get; private set; }
    }
}
