using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_de_Primer_Semestre_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2 ;
            double Promedio = 0, suma = 0, acumulador = 0;
            Console.Write("Los Factores son: ");
            while (n!=1)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                    suma += i;
                    acumulador++;
                }
                else
                    i += 1;
            }
            Promedio = suma / acumulador;
            Console.WriteLine();
            Console.WriteLine("Promedio: "+Promedio);
            Console.ReadKey();
        }
    }
}
