using EditoraCrescerInfraestrutura.Entidades;
using EditoraCrescerInfraestrutura.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditoraCrescerInfraestrutura
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=ExemploEC") { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new LivroMap());
        }
    }
}
