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

        
        public void AgregarTitulo(Titulo nuevoTitulo)
        {
            if (nuevoTitulo == null)
            {
                throw new ArgumentNullException(nameof(nuevoTitulo), "El título no puede ser nulo.");
            }
            catalogo.Add(nuevoTitulo);
        }

        public List<Titulo> ObtenerCatalogo()
        {
            return catalogo;
        }

        // ALGORITMO 1: Insertion Sort con protección para listas vacías
        public void OrdenarPorNombre()
        {
            if (catalogo.Count <= 1) return;

            for (int i = 1; i < catalogo.Count; i++)
            {
                Titulo clave = catalogo[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(catalogo[j].Nombre, clave.Nombre, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    catalogo[j + 1] = catalogo[j];
                    j--;
                }
                catalogo[j + 1] = clave;
            }
        }

        // ALGORITMO 2: Búsqueda Binaria con validación de entradas
        public Titulo? BuscarPorNombreBinario(string nombreBuscado)
        {
            if (string.IsNullOrWhiteSpace(nombreBuscado) || catalogo.Count == 0)
            {
                return null;
            }

            int izquierda = 0;
            int derecha = catalogo.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                int comparacion = string.Compare(catalogo[medio].Nombre, nombreBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    return catalogo[medio];
                }

                if (comparacion < 0)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return null;
        }
    }
}