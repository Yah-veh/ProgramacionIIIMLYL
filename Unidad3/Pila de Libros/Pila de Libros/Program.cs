using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_de_Libros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            Pila<Libro> p = new Pila<Libro>();
            while (opcion !=4)
            {
                Console.Clear();
                Console.WriteLine("1. Insetar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca Titulo");
                        String Titulo = Console.ReadLine();
                        Console.WriteLine("introduzca Autor");
                        String Autor = Console.ReadLine();
                        Console.WriteLine("introduzca Editorial");
                        String Editorial = Console.ReadLine();
                        Console.WriteLine("introduzca Año de Publicacion");
                        int AñoPublicacion = Convert.ToInt32(Console.ReadLine());
                        Libro x = new Libro(Titulo, Autor,Editorial,AñoPublicacion);
                        p.push(x);
                        break;
                    case 2:
                        Libro y = p.pop();
                        Console.WriteLine("El elemento eliminado es {0}", y.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }

        }
    }
}
