using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCliente
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
                Console.WriteLine("1. Ingresar");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Mostrar");


                Console.WriteLine("");

                Console.Write("Digite un valor entre 1-6: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //Proceso
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Titulo del Libro");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Autor");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Editorial");
                        string editorial = Console.ReadLine();
                        Console.WriteLine("Estado : Nuevo - Seminuevo - Viejo");
                        string srtEstado = Console.ReadLine();

                        Console.WriteLine();
                         o.CalcularOperacion( "1",titulo,autor,editorial,srtEstado);
                        break;
                    case 2:
               
                        break;
                    case 3:
                       Console.WriteLine( o.Mostrar("3"));
               
                        break;
              
                    default:

                        Console.WriteLine("Introduzca un valor entre 1 y 3");
                        break;
                }
                Console.WriteLine("");
                Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
