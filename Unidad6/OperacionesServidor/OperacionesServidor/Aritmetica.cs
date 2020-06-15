using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesServidor
{
    class Aritmetica
    {
        private static Aritmetica instance;

        private Aritmetica()
        {

        }
        public static Aritmetica getInstance()
        {
            if (instance == null)
            {
                instance = new Aritmetica();
            }
            return instance;
        }


        public double Sumar(double a, double b)
        {
            return a + b;

        }
        public double Restar(double a, double b)
        {
            return a - b;

        }
        public double Multiplicar(double a, double b)
        {
            return a * b;

        }
        public double Dividir(double a, double b)
        {
            return a / b;

        }
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Raiz(double a, double b)
        {
            return Math.Pow(a, (1 / b));

        }
    }
}

