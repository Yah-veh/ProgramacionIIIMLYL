using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicola_copia_de_internet
{
    class Program
    {
        int opc;
        int[] cola = new int[max];
        int final = -1;
        int frente = -1;
        public static int max = 10;
        public void Menu()
        {
            Console.WriteLine(" opciones: ");
            Console.WriteLine(" 1.Agregar por el frente  \n 2.agregar por el final  \n 3.eliminar por el frente  \n 4.eliminar por el final \n 5.imprimir elementos \n 6.salir");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: agregar_por_el_frente(); break;
                case 2: agregar_por_el_final(); break;
                case 3: eliminar_por_el_frente(); break;
                case 4: eliminar_por_el_final(); break;
                case 5: imprimir_elementos(); break;
                case 6: Console.WriteLine("Sesion finalizada"); break;
                default: Console.WriteLine("Seleccione una opcion del menu"); break;
            }
        }
        public Boolean vacia()
        {
            if (frente == -1)
                return true;
            else
                return false;
        }
        public Boolean llena()
        {
            if (frente == 0 && final == max - 1)
                return true;
            else
                return false;
        }
        public void agregar_por_el_frente()
        {
            if (llena() == true)
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
                cola[frente] = int.Parse(Console.ReadLine());
            }
            if (frente == -1)
            {
                frente++;
                cola[frente] = int.Parse(Console.ReadLine());
                if (frente == 0)//se igualan los datos
                { final = 0; }//se igualan los datos
            }
        }
        public void agregar_por_el_final()
        {
            if (llena() == true)
                Console.WriteLine("la cola esta llena");
            else
                Console.WriteLine("agregar dato");
            if (final < max - 1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
            }
            if (final == max - 1)
            {
                Console.WriteLine("no se puede agregar por el final");
            }
            if (final == -1)
            {
                final++;
                cola[final] = int.Parse(Console.ReadLine());
                if (final == 0)//se igualan los datos
                    frente = 0;//se igualan los datos
            }

        }
        public void eliminar_por_el_frente()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el frente" + cola[frente]);
            frente++;
        }
        public void eliminar_por_el_final()
        {
            if (vacia() == true)
                Console.WriteLine("La cola esta vacia");
            else
                Console.WriteLine("Se eliminara el dato por el final" + cola[final]);
            final--;
        }
        public void imprimir_elementos()
        {
            if (vacia() == true)//se verifica el estodo de la cola
                Console.WriteLine("Cola vacia");
            else
                for (int i = frente; i <= final; i++)// se crea un ciclo para recorrer los elementos
                    Console.Write(" " + cola[i] + '\t');//se captura el dato
            Console.WriteLine("  ");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            do
            {
                p.Menu();
            } while (p.opc != 6);
        }
    }

}
