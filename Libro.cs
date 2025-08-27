namespace Parcial
{
    //Se ingresa ISBN.
    // Mostrar título, autor, cantidad de préstamos y disponibilidad.
    public abstract class Libro
    {
        public int isbn {  get; set; }
        public int cantPrestamos { get; set; }
        public string titulo { get; set; }  
        public string autor { get; set; }
        public bool disponibilidad { get; set; }
        public static List<Libro> libros = new List<Libro>();
        public Libro (int isbn,string titulo, string autor, int cantPrestamos, bool disponibilidad)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.cantPrestamos = cantPrestamos;
            this.disponibilidad = disponibilidad;
        }
        public bool ValidarExistencia(List<Libro> libros)
        {
            bool valido = false;
            foreach (Libro libro in libros)
            {
                if (libro.isbn != isbn)
                {
                    valido = true;
                }
                
            }
            return valido;
        }


    }
}
