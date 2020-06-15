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
    class Biblioteca
    {
        string nombre;
        string direccion;
        int telefono;
        List<Libro> ListadeLibros;

        private static Biblioteca instance;

        public static Biblioteca getInstance()
        {
            if (instance == null)
            {
                instance = new Biblioteca();
            }
            return instance;
        }

        private Biblioteca()
        {
            this.nombre = "Biblioteca Univalle";
            this.direccion = "Pasaje guillermina";
            this.telefono = 64255233;
            ListadeLibros = new List<Libro>();
        }
        public void InsentarLibro(Libro m)

        {
            ListadeLibros.Add(m);
        }
        public void RemoverLibro(Libro l)

        {
            ListadeLibros.Remove(l);
        }
        public string MostrarLibros()

        {
            string respusta = "";

            foreach (Libro o in ListadeLibros)
            {
                respusta = respusta + o + "\n";
            }
            return "Libro:" + "\n" + respusta;
        }
    }
}