using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaGames.Infraestrutura.Mappings
{
    public class LocacaoMap : EntityTypeConfiguration<Locacao>
    {

        public LocacaoMap()
        {
            ToTable("Locacoes");

            HasRequired(x => x.Produto)
                .WithMany()
                .Map(x => x.MapKey("Id"));

            HasOptional(x => x.Pacote)
                .WithMany()
                .Map(x => x.MapKey("Id"));

            HasOptional(x => x.Opcional)
                .WithMany()
                .Map(x => x.MapKey("Id"));

            HasRequired(x => x.Cliente)
                .WithMany()
                .Map(x => x.MapKey("Id"));
                       
    }
}
}
