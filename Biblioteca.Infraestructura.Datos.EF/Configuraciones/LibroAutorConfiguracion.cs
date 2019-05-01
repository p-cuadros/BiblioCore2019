using System.Collections.Immutable;
using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infraestructura.Datos.EF.Configuraciones
{
    internal class LibroAutorConfiguracion : IEntityTypeConfiguration<LibroAutor>
    {
        public void Configure(EntityTypeBuilder<LibroAutor> builder)
        {
            builder.ToTable("LIBRO_AUTORES");
            builder.HasKey(k => new{k.IDLibro, k.IDAutor});
            builder.Property(p => p.IDLibro).HasColumnName("ID_LIBRO").IsRequired();
            builder.Property(p => p.IDAutor).HasColumnName("ID_AUTOR").IsRequired();
            builder.HasOne(m => m.Libro).WithMany().HasForeignKey(f => f.IDLibro);
            builder.HasOne(m => m.Autor).WithMany().HasForeignKey(f => f.IDAutor);
        }
    }
}