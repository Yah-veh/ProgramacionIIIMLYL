using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                ClienteSincrono o = ClienteSincrono.getInstance();

                Console.Clear();  //Limpia la pantalla

                //Entrada de Menu
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz");

                Console.WriteLine("");

                Console.Write("Digite un valor entre 1-6: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //Proceso
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Valor de a");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Sumar",a,b));
                        break;
                    case 2:
                        Console.WriteLine("Valor de a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Restar", a, b));
                        break;
                    case 3:
                        Console.WriteLine("Valor de a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Multiplicar", a, b));
                        break;
                    case 4:
                        Console.WriteLine("Valor de a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Dividir", a, b));
                        break;
                    case 5:
                        Console.WriteLine("Valor de a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Potencia", a, b));
                        break;
                    case 6:
                        Console.WriteLine("Valor de a");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Valor de b");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado " + o.CalcularOperacion("Raiz", a, b));
                        break;

                    default:

                        Console.WriteLine("Introduzca un valor entre 1 y 6");
                        break;
                }
                Console.WriteLine("");
                Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
