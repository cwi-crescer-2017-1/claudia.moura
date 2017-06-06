using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class OpcionalMap : EntityTypeConfiguration<Opcional>
    {
        public OpcionalMap()
        {
            ToTable("Opcionais");

            HasRequired(x => x.Produto)
                    .WithMany()
                    .Map(x => x.MapKey("Id"));
        }
    }
}
