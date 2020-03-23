using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero fibonacci");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=a;i++)
            Console.WriteLine("El fibonacci recursivo de {0}  es {1}",i, FibonaccilRecursivo(i));

            Console.ReadKey();
        }
        static int FibonaccilRecursivo(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonaccilRecursivo(n-1)+FibonaccilRecursivo(n-2);
        }
    }
}
