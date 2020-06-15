using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
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

        private  Biblioteca()
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
        public void MostrarLibros()

        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(nombre);
            Console.WriteLine(direccion);
            Console.WriteLine(telefono);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();

            foreach (Libro o in ListadeLibros)
            {
                Console.WriteLine("Libro");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("{0}     ", o);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
        }
    }
}
