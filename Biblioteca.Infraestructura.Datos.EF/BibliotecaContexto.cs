using System;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Dominio.Entidades;

namespace Biblioteca.Infraestructura.Datos.EF
{
    public class BibliotecaContexto : DbContext
    {    
        #region Constructor
            
        public BibliotecaContexto() {  }
        public BibliotecaContexto(DbContextOptions options) : base(options)
        {
        }

        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=157.230.50.;Database=Biblio2019;User Id=sql;Password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Configuraciones.LibroConfiguracion());
            modelBuilder.ApplyConfiguration(new Configuraciones.AutorConfiguracion());
            modelBuilder.ApplyConfiguration(new Configuraciones.LibroAutorConfiguracion());
            // modelBuilder.Entity<Libro>(e => e.HasKey(k => k.IDLibro));
            // modelBuilder.Entity<Autor>(e => e.HasKey(k => k.IDAutor));
            // modelBuilder.Entity<LibroAutor>(e => e.HasKey(k => new {k.IDLibro, k.IDAutor}));
            modelBuilder.Entity<Usuario>(e => e.HasKey(k => k.IDUsuario));
            modelBuilder.Entity<Ejemplar>(e => e.HasKey(k => k.IDEjemplar));
            modelBuilder.Entity<Prestamo>(e => e.HasKey(k => k.IDPrestamo));
        }

        #region Conjuntos de Datos
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<LibroAutor> LibroAutores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ejemplar> Ejemplares { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        #endregion
    }
}