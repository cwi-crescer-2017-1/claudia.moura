using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Dominio
{
    public class Permissao
    {
        public string Nome { get; private set; }
        public int IdPermissao { get; private set; }

        protected Permissao() { }//EF

        public Permissao(string nome)
        {
            Nome = nome;
        }
    }
}
