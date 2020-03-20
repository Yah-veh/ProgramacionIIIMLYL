using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practicando_con_Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Queue miCola = new Queue();
            miCola.Enqueue("Hola,");
            miCola.Enqueue("soy");
            miCola.Enqueue("yo");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miCola.Dequeue();
                Console.WriteLine(palabra);
            }
        }
    }
}
