using Parcial;
using System.Security.Cryptography.X509Certificates;
namespace ConsolaParcial
{
    class Program
    {
        static LibroVirtual libro1 = new LibroVirtual(1111, "C#"," ", 0,true);
        
        static void Main (string[] args)
        {
            
            List<Libro> libros = new List<Libro> ();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine( "---MENÚ PRINCIPAL---");
                Console.WriteLine("1- Registrar libro.");
                Console.WriteLine("2- Registrar préstamo de un libro.");
                Console.WriteLine("3- Mostrar información de un libro.");
                Console.WriteLine("4- Mostrar todos los libros y estadisticas generales.");
                Console.WriteLine("5- Salir.");
                Console.WriteLine("Seleccione una opción: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            RegistrarLibro(libros);
                            break;
                        case 2:
                            RegistrarPrestamo(libros);
                            break;
                        case 3:
                            MostrarLibro(libros);
                            break;
                        case 4:
                            MostrarInfoLibrosEst(libros);
                            //no llegue a hacer la parte de contar el total de prestamos y el total de libros fisicos y digitales.... ;(
                            //lo probe y compilo algoo!!!
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Ingreso fuera de rango, presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                else { Console.WriteLine("Ingreso no válido."); }
            }
            
            
        }
        public static void RegistrarLibro(List<Libro> libros)
        {
            Console.WriteLine("1- Libro físico.");
            Console.WriteLine("2- Libro virtual.");
            Console.WriteLine("Seleccione el tipo de libro a registrar: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada,out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("---INGRESAR DATOS CORRESPONDIENTES---");
                        Console.WriteLine("Ingrese el isbn del libro: ");
                        string ent = Console.ReadLine();
                        if (int.TryParse(ent, out int isbn))
                        {
                            libro1.ValidarExistencia(libros);
                            if(libro1.ValidarExistencia(libros) == true)
                            {
                                Console.WriteLine("Ingrese el título del libro: ");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Ingrese el autor del libro: ");
                                string autor = Console.ReadLine();
                                LibroFisico libro2 = new LibroFisico(isbn, titulo, autor, 0, true);
                                
                            }
                            else { Console.WriteLine( "El isbn pertenece a un libro ya cargado en el sistema."); }
                        }
                        else { Console.WriteLine("Ingreso no válido."); }
                            break;
                    case 2:
                        
                        Console.WriteLine("---INGRESAR DATOS CORRESPONDIENTES---");
                        Console.WriteLine("Ingrese el isbn del libro: ");
                        string enter = Console.ReadLine();
                        if (int.TryParse(enter, out int isbn_))
                        {
                            libro1.ValidarExistencia(libros);
                            if (libro1.ValidarExistencia(libros) == true)
                            {
                                Console.WriteLine("Ingrese el título del libro: ");
                                string titulo = Console.ReadLine();
                                Console.WriteLine("Ingrese el autor del libro: ");
                                string autor = Console.ReadLine();
                                LibroVirtual libro3 = new LibroVirtual(isbn_, titulo, autor, 0, true);

                            }
                            else { Console.WriteLine("El isbn pertenece a un libro ya cargado en el sistema."); }

                        }
                        else { Console.WriteLine("Ingreso no válido."); }
                            break;
                    default:
                        Console.WriteLine( "Opción fuera de rango, presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingreso no válido.");
            }
        }
        
        public static void RegistrarPrestamo(List<Libro> libros)
        {

            Console.WriteLine("---INGRESAR DATOS CORRESPONDIENTES---");
            Console.WriteLine("Ingrese el isbn del libro: ");
            string entrada = Console.ReadLine();
            if(int.TryParse(entrada, out int isbn_))
            {
                foreach (Libro libro in libros)
                {
                    if (libro.isbn == isbn_)
                    {
                        if (libro.disponibilidad == true)
                        {
                            libro.disponibilidad = false;
                            Console.WriteLine("El prestamo del libro se efectúo correctamente.");
                        }
                        else { Console.WriteLine("El préstamo del libro no se pudo efectuar debido a que no se encuentra disponible en este momento."); }
                    }
                    else { Console.WriteLine("El ISBN ingresado no corresponde a ningun libro disponible dentro del sistema."); }
                }
            }
            else { Console.WriteLine("Ingreso no válido."); }
        }
        public static string MostrarInfoLibrosEst(List<Libro> libros)
        {
            string infoLibro = "";
            foreach(Libro libro in libros)
            {
                infoLibro = $"ISBN del libro: {libro.isbn} Título: {libro.titulo} Autor: {libro.autor} Cantidad de prestamos: {libro.cantPrestamos} Disponibilidad: {libro.cantPrestamos}";
                
            }
            return infoLibro;
        }
        public static string MostrarLibro(List<Libro> libros)
        {
            string infoLibro = "";
            Console.WriteLine("Ingrese ISBN del libro: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int isbn_))
            {
                foreach (Libro libro in libros)
                {
                    if (libro.isbn == isbn_)
                    {
                        infoLibro = $"ISBN del libro: {libro.isbn} Título: {libro.titulo} Autor: {libro.autor} Cantidad de prestamos: {libro.cantPrestamos} Disponibilidad: {libro.cantPrestamos} ";
                    }
                    
                }
            }
            else { Console.WriteLine("No se encontro el ISBN ingresado." ); }
            return infoLibro;

        }

    }
}