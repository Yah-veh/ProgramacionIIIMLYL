using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                Biblioteca o = Biblioteca.getInstance();
                

                Console.Clear();  //Limpia la pantalla

                //Entrada de Menu
                Console.WriteLine("1. Ingresar Libro");
                Console.WriteLine("2. Remover Libro");
                Console.WriteLine("3. Mostrar");

                Console.WriteLine("");

                Console.Write("Digite un valor entre 1-3: ");
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
                        String srtEstado = Console.ReadLine();
                        Estado estado;
                        Enum.TryParse(srtEstado, out estado);


                        Libro a = new Libro(titulo, autor, editorial, estado);
                        o.InsentarLibro(a);
                        break;
                    case 2:
                        Console.WriteLine("Titulo del Libro");
                         titulo = Console.ReadLine();
                        Console.WriteLine("Autor");
                         autor = Console.ReadLine();
                        Console.WriteLine("Editorial");
                         editorial = Console.ReadLine();
                        a = new Libro(titulo, autor, editorial, Estado.Nuevo);
                        o.RemoverLibro(a);
          
                        break;
                    case 3:
                        o.MostrarLibros();
              
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
