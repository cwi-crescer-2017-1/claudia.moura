using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocaGames.Models
{
    public class FuncionarioModel
    {
        public Guid IdFuncionario { get;  set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
        public List<Permissao> Permissoes { get;  set; }
    }
}