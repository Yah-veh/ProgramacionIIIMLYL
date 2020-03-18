using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_otro_Numero
{
    class Program
    {
        delegate string Mdelegado(int a, int b);
        static void Main(string[] args)
        {
            Mdelegado mult = (int a, int b) =>
            {
                string aux;
                if (a % b == 0)
                    aux = "Es Multiplo";
                else
                    aux = "No es Multiplo";
                return aux;
            };
            
            Console.WriteLine(mult(4, 2));
            Console.ReadKey();
        }
    }
}
