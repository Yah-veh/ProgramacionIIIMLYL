using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            Cola<int> p = new Cola<int>();
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar Detras");
                Console.WriteLine("2. Insertar Adelante");
                Console.WriteLine("3. Eliminar Adelante");
                Console.WriteLine("4. Eliminar Detras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = int.Parse(Console.ReadLine());
                        p.InsertarFinal(x);
                        break;
                    case 2:
                        Console.WriteLine("introduzca un elemento");
                        x = int.Parse(Console.ReadLine());
                        p.InsertarAdelante(x);
                        break;
                    case 3:
                        x = p.EliminarAdelante();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 4:
                        x = p.EliminarFinal();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
