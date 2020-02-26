using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_19_02_20
{
    class Operaciones
    {
        public static double Factorial(double n)
        {
            int Fact = 1;
            for (int i = 1; i <= n; i++)
            {
                Fact = Fact * i;
            }
            return Fact;
        }
        public static double Sumatoria(double n)
        {
            int Sumatoria = 0;
            for (int i = 0; i <= n; i++)
            {
                Sumatoria +=  i;
            }
            return Sumatoria;
        }
    }
}
