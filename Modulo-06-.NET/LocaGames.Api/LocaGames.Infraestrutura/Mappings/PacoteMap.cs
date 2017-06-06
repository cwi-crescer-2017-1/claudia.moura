using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class PacoteMap : EntityTypeConfiguration<Pacote>
    {
        public PacoteMap()
        {
            ToTable("Pacotes");
        }
        HasRequired(x => x.Produto)
                .WithMany()
                .Map(x => x.MapKey("Id"));
    }
}
