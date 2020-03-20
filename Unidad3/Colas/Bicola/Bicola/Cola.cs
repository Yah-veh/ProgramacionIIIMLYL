using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicola
{
    class Cola<T>
    {
        public const int Maximo = 10;
        private T[] arreglo = new T[Maximo];
        private int final = -1;
        private int frente = 0;

        public void InsertarAdelante(T valor)
        {
           
                if (LLena() == true)
                    Console.WriteLine("la cola esta llena");
                else
                    Console.WriteLine("agregar dato");
                if (frente == 0)
                {
                    Console.WriteLine("no se puede agregar por el frente");
                }
                if (frente > 0)
                {
                    frente--;
                    arreglo[frente] = valor;
                }
                if (frente == -1)
                {
                    frente++;
                    arreglo[frente] = valor;
                    if (frente == 0)//se igualan los datos
                    { final = 0; }//se igualan los datos
                }      
        }
        public void InsertarFinal(T valor)
        {

            if (LLena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (final < final - 1)
            {
                final++;
                arreglo[final] = valor;
            }
            if (final == final - 1)
            {
                Console.WriteLine("no se puede agregar por el final");
            }
            if (final == -1)
            {
                final++;
                arreglo[final] = valor;
                if (final == 0)
                    frente = 0;
            }
        }
        public T EliminarAdelante()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }

        }
        public T EliminarFinal()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[final];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[final];
            }
        }
        public void mostrar()
        {
            for (int i = frente; i <= final; i++)
                Console.Write(arreglo[i] + " ");

        }
        private Boolean Vacia()
        {
            return final < frente;
        }
        private Boolean LLena()
        {
            return final == Maximo;
        }

    }
}
