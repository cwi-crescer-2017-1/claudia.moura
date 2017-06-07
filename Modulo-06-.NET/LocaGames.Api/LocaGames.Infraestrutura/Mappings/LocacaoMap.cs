using LocaGames.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
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

            HasKey(x => x.IdLocacao);

            Property(x => x.IdLocacao)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.ValorTotal).IsRequired();

            HasRequired(x => x.Console)//Produto?
                .WithMany()
                .Map(x => x.MapKey("IdProduto"));

            HasOptional(x => x.Pacote)
                .WithMany()
                .Map(x => x.MapKey("IdPacote"));

            HasRequired(x => x.Cliente)
                .WithMany()
                .Map(x => x.MapKey("IdCliente"));


        }
    }
}