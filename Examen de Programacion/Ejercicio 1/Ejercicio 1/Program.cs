using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear un arreglo de int, double y char
            int[] intArray = { 4,2,3 };
            double[] doubleArray = { 2.3, 3.1 ,4.6,};
            string[] stringArray = { "Juan", "Pedro", "Maria" };

            Console.WriteLine("Arreglo inicial:");
            Mostrar(intArray);
            Console.WriteLine("Arreglo primero y segudo:");
            Ordenar(intArray);
            Mostra(intArray);
            Console.WriteLine("Arreglo inicial:");
            Mostrar(doubleArray);
            Console.WriteLine("Arreglo primero y segudo:");
            Ordenar(doubleArray);
            Mostra(doubleArray);
            Console.WriteLine("Arreglo inicial:");
            Mostrar(stringArray);
            Console.WriteLine("Arreglo primero y segudo:");
            Ordenar(stringArray);
            Mostra(stringArray);

            Console.ReadKey();
        }
        private static void Mostrar<T>(T[] arreglo)
        {
            foreach (T element in arreglo)
                Console.Write(element + " ");
            Console.WriteLine("\n");
        }
        private static void Mostra<T>(T[] arreglo)
        {
            
            for (int f = 0; f < 2; f++)
            {
               
                Console.WriteLine(arreglo[f]);
                
            }
            Console.WriteLine("\n");
        }
      
        private static void Ordenar<T>(T[] a)
            where T : IComparable<T>
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i > a.Length - 1 - j; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0)
                    {
                        T aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                    }
                }
            }
        }

    }
}
