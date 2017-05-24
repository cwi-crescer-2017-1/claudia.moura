using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Pessoa
    {
        public const double PI = 3.14;
        public readonly double PIreadonly;

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int? Id { get; set; } //valor opcional

    }
}


