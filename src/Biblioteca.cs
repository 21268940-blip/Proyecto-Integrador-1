using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    public class Biblioteca
    {
        private List<Titulo> catalogo;

        public Biblioteca()
        {
            catalogo = new List<Titulo>();
        }

        // Método para agregar títulos
        public void AgregarTitulo(Titulo nuevoTitulo)
        {
            catalogo.Add(nuevoTitulo);
        }

        // Método para obtener la lista actual
        public List<Titulo> ObtenerCatalogo()
        {
            return catalogo;
        }

        // ALGORITMO 1: Ordenamiento por Inserción (Insertion Sort) manual por Nombre
        public void OrdenarPorNombre()
        {
            for (int i = 1; i < catalogo.Count; i++)
            {
                Titulo clave = catalogo[i];
                int j = i - 1;

                // Compara cadenas lexicográficamente
                while (j >= 0 && string.Compare(catalogo[j].Nombre, clave.Nombre, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    catalogo[j + 1] = catalogo[j];
                    j--;
                }
                catalogo[j + 1] = clave;
            }
        }

        // ALGORITMO 2: Búsqueda Binaria manual por Nombre exacto
        // NOTA: El catálogo DEBE estar ordenado antes de ejecutar este método
        public Titulo BuscarPorNombreBinario(string nombreBuscado)
        {
            int izquierda = 0;
            int derecha = catalogo.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                int comparacion = string.Compare(catalogo[medio].Nombre, nombreBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return catalogo[medio]; // Elemento encontrado
                }

                if (comparacion < 0)
                {
                    izquierda = medio + 1; // Buscar en la mitad derecha
                }
                else
                {
                    derecha = medio - 1; // Buscar en la mitad izquierda
                }
            }

            return null; // Elemento no encontrado
        }
    }
}