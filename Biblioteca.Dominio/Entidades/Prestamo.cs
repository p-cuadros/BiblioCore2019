using System;
namespace Biblioteca.Dominio.Entidades
{
    public class Prestamo
    {
        public int IDPrestamo { get; private set; }
        public int IDEjemplar { get; private set; }
        public int IDUsuario { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime? FechaDevolucion { get; private set; }

        public virtual Usuario Lector { get; set; }
        public virtual Ejemplar EjemplarPrestado { get; set; }
        
    }
}