using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_de_Rentistas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Rentista x;
            Cola<Rentista> c = new Cola<Rentista>();
            Rentista r;

            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca Nombre");
                        String Nombre = Console.ReadLine();
                        Console.WriteLine("introduzca Apellido");
                        String Apelldio = Console.ReadLine();
                        Console.WriteLine("introduzca Sexo");
                        String Sexo = Console.ReadLine();
                        Console.WriteLine("introduzca Edad");
                        int Edad = Convert.ToInt32( Console.ReadLine());
                        Console.WriteLine("introduzca Sector");
                        String Sector = Console.ReadLine();
                        r = new Rentista(Nombre, Apelldio, Sexo, Edad, Sector);
                        c.Insertar(r);
                        break;
                    case 2:
                        x = c.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        c.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
