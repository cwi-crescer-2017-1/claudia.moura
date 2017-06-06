using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionarios");

        }
    }

}
