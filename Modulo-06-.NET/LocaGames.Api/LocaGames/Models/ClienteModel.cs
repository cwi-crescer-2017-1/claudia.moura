using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocaGames.Models
{
    public class ClienteModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}