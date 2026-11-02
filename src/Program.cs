using System;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblioteca = new Biblioteca();
            bool salir = false;

            // Datos iniciales de prueba
            miBiblioteca.AgregarTitulo(new Titulo("B001", "Cien Anos de Soledad", "Gabriel Garcia Marquez", 5));
            miBiblioteca.AgregarTitulo(new Titulo("B002", "Don Quijote de la Mancha", "Miguel de Cervantes", 3));
            miBiblioteca.AgregarTitulo(new Titulo("B003", "El Aleph", "Jorge Luis Borges", 10));
            miBiblioteca.AgregarTitulo(new Titulo("B004", "Rayuela", "Julio Cortazar", 2));

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("   SISTEMA DE GESTIÓN DE BIBLIOTECA ESCOLAR");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Registrar nuevo libro");
                Console.WriteLine("2. Mostrar catálogo de libros");
                Console.WriteLine("3. Ordenar catálogo por Título (Insertion Sort)");
                Console.WriteLine("4. Buscar libro por Título (Búsqueda Binaria)");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==================================================");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n--- REGISTRAR NUEVO LIBRO ---");
                        Console.Write("ID del libro: ");
                        string id = Console.ReadLine();
                        Console.Write("Título del libro: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Cantidad de ejemplares: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidad))
                        {
                            miBiblioteca.AgregarTitulo(new Titulo(id, nombre, autor, cantidad));
                            Console.WriteLine("\n¡Libro registrado exitosamente!");
                        }
                        else
                        {
                            Console.WriteLine("\nError: La cantidad debe ser un número entero.");
                        }
                        Pausar();
                        break;

                    case "2":
                        Console.WriteLine("\n--- CATÁLOGO ACTUAL DE LA BIBLIOTECA ---");
                        var catalogo = miBiblioteca.ObtenerCatalogo();
                        if (catalogo.Count == 0)
                        {
                            Console.WriteLine("El catálogo está vacío.");
                        }
                        else
                        {
                            foreach (var libro in catalogo)
                            {
                                Console.WriteLine(libro);
                            }
                        }
                        Pausar();
                        break;

                    case "3":
                        Console.WriteLine("\n--- ORDENANDO CATÁLOGO ---");
                        miBiblioteca.OrdenarPorNombre();
                        Console.WriteLine("¡Catálogo ordenado alfabéticamente por Título utilizando Insertion Sort!");
                        Pausar();
                        break;

                    case "4":
                        Console.WriteLine("\n--- BÚSQUEDA BINARIA DE LIBROS ---");
                        Console.Write("Ingrese el título exacto a buscar: ");
                        string tituloBuscado = Console.ReadLine();

                        // Se recomienda ordenar primero para asegurar el correcto funcionamiento de la Búsqueda Binaria
                        miBiblioteca.OrdenarPorNombre();
                        
                        Titulo encontrado = miBiblioteca.BuscarPorNombreBinario(tituloBuscado);

                        if (encontrado != null)
                        {
                            Console.WriteLine($"\n[ENCONTRADO] -> {encontrado}");
                        }
                        else
                        {
                            Console.WriteLine("\n[NO ENCONTRADO] El libro no existe en el catálogo.");
                        }
                        Pausar();
                        break;

                    case "5":
                        salir = true;
                        Console.WriteLine("\nSaliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        Pausar();
                        break;
                }
            }
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}