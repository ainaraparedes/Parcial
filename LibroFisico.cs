using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class LibroFisico : Libro
    {
        //public int contFisico {  get; set; }
        public LibroFisico(int isbn, string titulo, string autor,int cantPrestamos, bool disponibilidad) : base(isbn, titulo, autor, cantPrestamos, disponibilidad)
        {

        }
    }
}
