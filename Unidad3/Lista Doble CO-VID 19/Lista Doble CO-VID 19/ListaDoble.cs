using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Doble_CO_VID_19
{
    class Nodo
    {
        public PersonasContagiadas info;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(PersonasContagiadas valor)
        {
            info = valor;
            Siguiente = null;
        }
    }
    class ListaDoble
    {
        public Nodo Actual;
        public void Insertar(PersonasContagiadas valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Actual == null)
            {
                Actual = nuevo;
            }
            else
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux != null && valor.Apellido.CompareTo(aux.info.Apellido)>0)
                {
                    ant = aux;
                    aux = aux.Siguiente;

                }
                if (ant == null)
                {
                    Actual = nuevo;
                    nuevo.Siguiente = aux;
                    aux.Anterior = nuevo;
                }
                else
                {
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                    nuevo.Anterior = ant;
                }

            }
        }
        public void Eliminar(string Apellido)
        {
            if (Actual != null)
            {
                Nodo aux = Actual;
                Nodo ant = null;
                while (aux.Siguiente != null && aux.info.Apellido != Apellido)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                if (aux.info.Apellido == Apellido)
                {
                    if (ant == null)
                        Actual = aux.Siguiente;
                    else
                        ant.Siguiente = aux.Siguiente;
                }
                else
                    Console.WriteLine("No se encontro el valor");


            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Elementos de la lista:");
            if (Actual != null) // que la lista no estee vacia
            {
                Nodo aux = Actual;
                while (aux != null)
                {
                    Console.Write("{0}     ", aux.info);
                    aux = aux.Siguiente;

                }
            }
        }

    }
}
