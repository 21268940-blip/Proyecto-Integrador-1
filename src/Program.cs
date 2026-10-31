using System;

namespace BibliotecaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE BIBLIOTECA ESCOLAR ===");

            // 1. Instanciamos la biblioteca
            Biblioteca miBiblioteca = new Biblioteca();

            // 2. Agregamos algunos títulos desordenados
            miBiblioteca.AgregarTitulo(new Titulo("B001", "Cien Anos de Soledad", "Gabriel Garcia Marquez", 5));
            miBiblioteca.AgregarTitulo(new Titulo("B002", "Don Quijote de la Mancha", "Miguel de Cervantes", 3));
            miBiblioteca.AgregarTitulo(new Titulo("B003", "El Aleph", "Jorge Luis Borges", 10));
            miBiblioteca.AgregarTitulo(new Titulo("B004", "Rayuela", "Julio Cortazar", 2));

            Console.WriteLine("\n--- Catálogo Desordenado ---");
            foreach (var libro in miBiblioteca.ObtenerCatalogo())
            {
                Console.WriteLine(libro);
            }

            // 3. Probamos nuestro algoritmo de ordenamiento por inserción
            miBiblioteca.OrdenarPorNombre();

            Console.WriteLine("\n--- Catálogo Ordenado por Nombre (Insertion Sort) ---");
            foreach (var libro in miBiblioteca.ObtenerCatalogo())
            {
                Console.WriteLine(libro);
            }

            // 4. Probamos nuestro algoritmo de búsqueda binaria
            string libroBuscado = "Don Quijote de la Mancha";
            Console.WriteLine($"\n--- Buscando el libro: '{libroBuscado}' (Búsqueda Binaria) ---");
            
            Titulo resultado = miBiblioteca.BuscarPorNombreBinario(libroBuscado);

            if (resultado != null)
            {
                Console.WriteLine($"¡Encontrado! -> {resultado}");
            }
            else
            {
                Console.WriteLine("El libro no se encuentra en la biblioteca.");
            }
        }
    }
}