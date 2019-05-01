namespace Biblioteca.Dominio.Entidades
{
    public class Ejemplar
    {
        public int IDEjemplar { get; private set; }
        public int IDLibro { get; private set; }
        public virtual Libro Libro { get; private set; }
    }
}