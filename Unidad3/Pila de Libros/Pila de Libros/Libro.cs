using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_de_Libros
{
    class Libro
    {
        public Libro(string titulo, string autor, string editorial, int añoDePublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AñoDePublicacion = añoDePublicacion;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñoDePublicacion { get; set; }
        public override string ToString()
        {
            return Titulo + " " + Autor + " " + Editorial + " " + AñoDePublicacion.ToString();
        }
    }
}
