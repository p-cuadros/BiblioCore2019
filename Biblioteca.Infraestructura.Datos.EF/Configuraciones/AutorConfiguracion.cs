using System.Collections.Immutable;
using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infraestructura.Datos.EF.Configuraciones
{
    internal class AutorConfiguracion : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("AUTORES");
            builder.HasKey(k => k.IDAutor);
            builder.Property(p => p.IDAutor).HasColumnName("ID_AUTOR").IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Nombre).HasColumnName("NOM_AUTOR").IsRequired().HasColumnType("VARCHAR(100)");
        }
    }
}