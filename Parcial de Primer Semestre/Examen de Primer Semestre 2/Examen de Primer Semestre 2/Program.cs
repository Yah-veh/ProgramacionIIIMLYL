using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_de_Primer_Semestre_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, a = 1; ;
            Console.Write("Pi = ");
            while(i<n)
            {
               if(i%2==1)
               {
                    Console.Write("-(4/{0}) ", a);
               }
               else
                    Console.Write("(4/{0}) ", a);
                a += 2;
                i++;
            }
            Console.ReadKey();
        }
    }
}
