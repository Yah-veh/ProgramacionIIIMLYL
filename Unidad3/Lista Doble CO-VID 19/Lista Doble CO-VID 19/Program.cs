    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Doble_CO_VID_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            PersonasContagiadas x;
            ListaDoble l =new ListaDoble();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Ordenar");

                Console.WriteLine("5. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca Nombre");
                        String Nombre = Console.ReadLine();
                        Console.WriteLine("introduzca Apellido");
                        String Apellido = Console.ReadLine();
                        Console.WriteLine("introduzca Edad");
                        int Edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("introduzca Sexo");
                        string Sexo = Console.ReadLine();
                        Console.WriteLine("introduzca Estado");
                        String Estado= Console.ReadLine();
                        x = new PersonasContagiadas(Nombre, Apellido,Edad, Sexo, Estado);
                        l.Insertar(x);
                        break;
                    case 2:
                        Console.WriteLine("Apellido de la persona que quiere eliminar");
                        string ApellidoBorrar = Console.ReadLine();
                        l.Eliminar(ApellidoBorrar);
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
