using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_un_arreglo_mediante_generico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la Cadena");
            string a = Console.ReadLine();
            char[] arreglo = a.ToCharArray();
            Console.WriteLine("La Cadena Ordenada Contiene");
            MuestraArreglo(arreglo);

            Console.ReadKey();
        }
        // método genérico para mostrar un arreglo
        private static void MuestraArreglo<T>(T[] arreglo)
        {
            Array.Sort(arreglo);
            Array.Reverse(arreglo);
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
    }
}
}
