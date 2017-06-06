using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Locacao
    {
        public int Id { get; private set; }
        public Produto Console { get; private set; }
        public Pacote Pacote { get; private set; }
        public Opcional Opcional { get; private set; }
        public double ValorTotal { get; private set; }
        public DateTime? Data { get; private set; }
        public Cliente Cliente { get; private set; }
    }
}
