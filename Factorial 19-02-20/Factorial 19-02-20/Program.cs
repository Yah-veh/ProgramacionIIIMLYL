using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_19_02_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de Factorial");
            int n = int.Parse(Console.ReadLine());         
            Console.WriteLine("El Factorial es: {0}",Operaciones.Factorial(n));
            Console.WriteLine("La sumatoria es: {0}",Operaciones.Sumatoria(n));
            Console.ReadKey();
        }
    }
}
