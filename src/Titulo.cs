using System;

namespace BibliotecaEscolar
{
    public class Titulo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        
        // Esta propiedad cumple con el requisito de manejar "cantidades irregulares de ejemplares"
        public int CantidadEjemplares { get; set; }

        public Titulo(string id, string nombre, string autor, int cantidadEjemplares)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            CantidadEjemplares = cantidadEjemplares;
        }

        // Sobrescribimos ToString para que sea fácil imprimir el objeto en la consola más adelante
        public override string ToString()
        {
            return $"ID: {Id} | Título: {Nombre} | Autor: {Autor} | Ejemplares: {CantidadEjemplares}";
        }
    }
}