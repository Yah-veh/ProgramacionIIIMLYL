using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_de_Primer_Semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = Convert.ToInt32(Console.ReadLine());
            double i = 0,b=0,c=0,Salida=0,a;        
            while(N!=0)
            {
                a = N % 10;
                if (a%2==1)
                {
                    Salida +=a*a;
                }
                b = N / 10;
                c = Math.Truncate(b);
                N = c;
                i++;             
            }
            Console.WriteLine(Salida);

           
            Console.ReadKey();
           
        }
    }
}
