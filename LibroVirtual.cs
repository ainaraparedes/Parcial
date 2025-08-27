using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class LibroVirtual : Libro
    {
        //public int contVirtual { get; set; }
        public LibroVirtual ( int isbn, string titulo, string autor, int cantPrestamos, bool disponibilidad) : base(isbn, titulo, autor, cantPrestamos, disponibilidad)
        {

        }
    }
}
