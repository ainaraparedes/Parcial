using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Usuario 
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public Usuario(int id, string nombre)
        {
            this.Id = id;
            this.nombre = nombre;
        }
    }
}
