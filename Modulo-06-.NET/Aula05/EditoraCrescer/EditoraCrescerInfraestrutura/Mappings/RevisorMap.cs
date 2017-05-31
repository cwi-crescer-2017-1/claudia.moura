using EditoraCrescerInfraestrutura.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescerInfraestrutura.Mappings
{
    class RevisorMap : EntityTypeConfiguration<Autor>
    {
        public RevisorMap()
        {
            ToTable("Revisores");
        }
    }
}
