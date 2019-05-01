using System.Collections.Immutable;
using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infraestructura.Datos.EF.Configuraciones
{
    internal class LibroConfiguracion : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
            builder.ToTable("LIBROS");
            builder.HasKey(k => k.IDLibro);
            builder.Property(p => p.IDLibro).HasColumnName("ID_LIBRO").IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.TituloLibro).HasColumnName("TITULO").IsRequired().HasColumnType("VARCHAR(300)");
            builder.Property(p => p.ISBN).HasColumnName("ISBN").IsRequired().HasColumnType("VARCHAR(25)");
            builder.Property(p => p.NumeroPaginas).HasColumnName("NUM_PAGINAS").IsRequired();
            builder.Property(p => p.IDEditorial).HasColumnName("ID_EDITORIAL").IsRequired();
            builder.Property(p => p.IDTipoLibro).HasColumnName("ID_TIPO_LIBRO").IsRequired();
        }
    }
}