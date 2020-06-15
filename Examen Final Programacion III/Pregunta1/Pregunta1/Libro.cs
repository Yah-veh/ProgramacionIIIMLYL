using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Libro
    {
        string titulo;
        string autor;
        string editorial;
        Estado estado;

        public Libro(string titulo, string autor, string editorial, Estado estado)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.estado = estado;

        }
        public string getTitulo()
        {
            return titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getAutor()
        {
            return autor;
        }
        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public string getEditorial()
        {
            return editorial;
        }
        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }
        public override string ToString()
        {
            return "Titulo:" + titulo + " Autor:" + autor + " Editorial:" + editorial + " Estado:" + estado ;
        }


    }
    enum Estado
    {
        Nuevo, Seminuevo, Viejo
    }
   
}
