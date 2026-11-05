using System;
using System.Collections.Generic;
using System.IO;

namespace BibliotecaEscolar
{
    public class Biblioteca
    {
        private List<Titulo> catalogo;
        private readonly string rutaArchivo = "catalogo.txt";

        public Biblioteca()
        {
            catalogo = new List<Titulo>();
        }

        public void AgregarTitulo(Titulo nuevoTitulo)
        {
            if (nuevoTitulo == null) throw new ArgumentNullException(nameof(nuevoTitulo));
            catalogo.Add(nuevoTitulo);
        }

        public List<Titulo> ObtenerCatalogo() => catalogo;

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

        public Titulo? BuscarPorNombreBinario(string nombreBuscado)
        {
            if (string.IsNullOrWhiteSpace(nombreBuscado) || catalogo.Count == 0) return null;

            int izquierda = 0;
            int derecha = catalogo.Count - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                int comparacion = string.Compare(catalogo[medio].Nombre, nombreBuscado, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0) return catalogo[medio];
                if (comparacion < 0) izquierda = medio + 1;
                else derecha = medio - 1;
            }

            return null;
        }

        // --- PERSISTENCIA DE DATOS (DÍA 6) ---
        public void GuardarEnArchivo()
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (var libro in catalogo)
                {
                    // Formato: ID|Nombre|Autor|Cantidad
                    writer.WriteLine($"{libro.Id}|{libro.Nombre}|{libro.Autor}|{libro.CantidadEjemplares}");
                }
            }
        }

        public void CargarDesdeArchivo()
        {
            if (!File.Exists(rutaArchivo)) return;

            catalogo.Clear();
            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] datos = linea.Split('|');
                if (datos.Length == 4 && int.TryParse(datos[3], out int cantidad))
                {
                    catalogo.Add(new Titulo(datos[0], datos[1], datos[2], cantidad));
                }
            }
        }
    }
}