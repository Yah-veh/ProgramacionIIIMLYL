using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pregunta3
{
    class Libro
    {
        string titulo;
        string autor;
        string editorial;
        string estado;

        public Libro(string titulo, string autor, string editorial, string estado)
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
            return "Titulo:" + titulo + " Autor:" + autor + " Editorial:" + editorial + " Estado:" + estado;
        }


    }
    enum Estado
    {
        Nuevo, Seminuevo, Viejo
    }
}
