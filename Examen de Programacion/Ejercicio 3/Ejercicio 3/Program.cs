using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Operaciones 
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaImaginario; 
        public double Raices(int a, int b,int c)
        {
            double raiz = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            int disparo = b * b - 4 * a * c;
            double x1 = ((-b + raiz)) / (2 * a);
            double x2 = ((-b - raiz)) / (2 * a);
            if ((disparo< 0) && (CuandoRecibaImaginario != null))  
            { CuandoRecibaImaginario(disparo); }
            return x2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            o.CuandoRecibaImaginario += RecibeImaginario;
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double raices = o.Raices(a, b, c);

        }
        static void RecibeImaginario(int n) // Manejador de Evento
        {
            Console.WriteLine("Se obtuvo un Imaginario {0}", n);
        }
    }
}
