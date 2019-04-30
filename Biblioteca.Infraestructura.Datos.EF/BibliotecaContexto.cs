using System;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Dominio.Entidades;

namespace Biblioteca.Infraestructura.Datos.EF
{
    public class BibliotecaContexto : DbContext
    {    
        public BibliotecaContexto()
        {
    
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Libro> Libros { get; set; }
    }
}