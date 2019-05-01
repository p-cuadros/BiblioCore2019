namespace Biblioteca.Dominio.Entidades
{
    public class LibroAutor
    {
        public int IDLibro { get; private set; }
        public int IDAutor { get; private set; }

        public virtual Libro Libro { get; private set; }
        public virtual Autor Autor { get; private set; }
    }
    
}