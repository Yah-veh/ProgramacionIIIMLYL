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
        public double RaicesPositiva(int a, int b,int c)
        {
            double raiz = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            int disparo = b * b - 4 * a * c;
            double x1 = ((-b + raiz)) / (2 * a);        
            if ((disparo< 0) && (CuandoRecibaImaginario != null))  
            { CuandoRecibaImaginario(disparo); }
            return x1;
        }
        public double RaicesNegativa(int a, int b, int c)
        {
            double raiz = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            int disparo = b * b - 4 * a * c;
            double x2 = ((-b - raiz)) / (2 * a);
            if ((disparo < 0) && (CuandoRecibaImaginario != null))
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
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            double x1 = o.RaicesPositiva(a, b, c);
            double x2 = o.RaicesNegativa(a, b, c);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);

            Console.ReadKey();


        }
        static void RecibeImaginario(int n) // Manejador de Evento
        {
            Console.WriteLine("Se obtuvo un Imaginario {0}", n);
        }
    }
}
