using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_generico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entero = { 1, 2, 3, 4, 5, 6 };
            double[] reales = { -3.3, -2.2, -1.1, 0, 1.1, 2.2, 3.3 };
            string[] cadenas = { "Alberto", "Bartolina", "Carlos", "Daniel", "Edgar" };
            Console.WriteLine("Arreglo de Enteros: ");
            Imprimir(entero);
            Console.WriteLine("Arreglo de Enteros despues de Ordenar ");
            Ordenar(entero);
            Imprimir(entero);
            Console.WriteLine("Arreglo de Reales: ");
            Imprimir(reales);
            Console.WriteLine("Arreglo de despues de Ordenar ");
            Ordenar(reales);
            Imprimir(reales);
            Console.WriteLine("Arreglo de Cadenas: ");
            Imprimir(cadenas);
            Console.WriteLine("Arreglo de despues de Ordenar ");
            Ordenar(cadenas);
            Imprimir(cadenas);
            Console.ReadKey();
        }
        private static void Ordenar<T>(T[] arreglo)
            where T : IComparable<T>
        {
            
            for(int j=0;j<arreglo.Length;j++)
            {
                for(int i=0; i<arreglo.Length-1-j;i++)
                {
                   
                    if(arreglo[i].CompareTo(arreglo[i+1])<0)
                    {
                        T aux = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = aux;
                    }
                }
            }

        }
        private static void Imprimir<T>(T[] arreglo)
        {                
            foreach (T elemento in arreglo)
                Console.Write(elemento + " ");
            Console.WriteLine("\n");
        }
}
}
