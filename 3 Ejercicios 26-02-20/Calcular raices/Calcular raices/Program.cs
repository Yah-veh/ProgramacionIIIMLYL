using System;

namespace Calcular_raices
{
    class Program
    {
        delegate double Raices(double a, double b, double c);
        static void Main(string[] args)
        {
            Raices RaizNegativa = (double a, double b, double c) =>
            { return ((-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a)); };

            Raices RaizPositiva = (double a, double b, double c) =>
            { return (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)); };       
         
            Console.WriteLine(RaizPositiva(1, 8, 3));
            Console.WriteLine(RaizNegativa(1, 8, 3));
            Console.ReadKey();

        }
    }
}
    