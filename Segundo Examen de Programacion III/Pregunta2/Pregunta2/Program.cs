using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoCentral uno = BancoCentral.getInstance();
            int opcion = 0;
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Colocar Fecha");
                Console.WriteLine("2. Mostrar Valor");
                Console.WriteLine("3. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Indotruzca Fecha (Formato: DD/MM/AAAA)");
                        string fechaActual = Console.ReadLine();
                        uno.ingresarFecha(fechaActual);
                       
                        break;
                    case 2:
                
                        uno.Mostrar();
                        break;
                    case 3:
                     
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
