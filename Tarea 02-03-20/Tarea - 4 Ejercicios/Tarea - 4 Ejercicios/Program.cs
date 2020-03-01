using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___4_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;

                Console.Clear();  //Limpia la pantalla

                //Entrada de Menu
                Console.WriteLine("1. Realizar un programa e c# utilizando expresiones lambda que permita calcular las 2 raices de una ecuación de segundo grado dela forma ax2 + bx + c = 0");
                Console.WriteLine("2. Realizar u programa en c# utlizando expresiones lambda uq determine si un numero n es múltiplo de otro numero m");
                Console.WriteLine("3. Realizar un programa en c# utilizando expresiones lambda que dado un numero me devuelva el día de la semana ");
                Console.WriteLine("4. Realizar un programa en c# utilizando expresiones lambda que determine si un numero es primo");
                Console.WriteLine("");

                Console.Write("Digite un valor entre 1-4: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //Proceso
                switch (n)
                {
                    case 1:
                        Uno();
                        break;
                    case 2:
                        Dos();
                        break;
                    case 3:
                        Tres();
                        break;
                    case 4:
                        Cuatro();
                        break;               
                    default:

                        Console.WriteLine("Introduzca un valor entre 1 y 4");
                        break;
                }
                Console.WriteLine("");
                Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        delegate double Raices(double a, double b, double c);
        static void Uno()
        {

            Raices RaizNegativa = (double a, double b, double c) =>
            { return ((-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a)); };

            Raices RaizPositiva = (double a, double b, double c) =>
            { return ((-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a)); };

            Console.WriteLine(RaizPositiva(1, 8, 3));
            Console.WriteLine(RaizNegativa(1, 8, 3));
            Console.ReadKey();
        }

        delegate string Mdelegado(int a, int b);
        static void Dos()
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
        delegate string Msemana(int a);
        static void Tres()
        {
            Msemana DiadeSemana = (int a) =>
              {      
                 switch(a)
                 {
                      case 1:
                          Console.WriteLine("Lunes");
                          break;
                      case 2:
                          Console.WriteLine("Martes");
                          break;
                      case 3:
                          Console.WriteLine("Miercoles");
                          break;
                      case 4:
                          Console.WriteLine("Jueves");
                          break;
                      case 5:
                          Console.WriteLine("Viernes");
                          break;
                      case 6:
                          Console.WriteLine("Sabado");
                          break;
                      case 7:
                          Console.WriteLine("Domingo");
                          break;
                  }
                  return a.ToString();
              };
            Console.WriteLine("Indotruzca numero de la semana");
            int n = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(DiadeSemana(n));
        }
        delegate string Mprimo(int a);
        static void Cuatro()
        {
            Mprimo NumeroPrimo = (int n) =>
            {
                int a = 0;
                string b;
                for (int i = 1; i < (n + 1); i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a != 2)
                {
                    b = "No es Primo";
                }
                else
                {
                    b = "Si es Primo";
                }
                return b;
            };
            Console.WriteLine("Introduzca numero para identificar si es primo");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumeroPrimo(N));
         
        }
    }
    
}
