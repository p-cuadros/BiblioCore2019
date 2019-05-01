using System;

namespace Biblioteca.Dominio.Entidades
{
    public class Libro
    {
        public int IDLibro { get; private set; }
        public string TituloLibro { get; private set; }
        public string ISBN { get; private set; }
        public short NumeroPaginas { get; private set; }
        public short IDEditorial { get; private set; }
        public byte IDTipoLibro { get; private set; }
    }
}
