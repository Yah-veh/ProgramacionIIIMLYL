using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ListaDeEntero = new int[100000];
            Random azar = new Random();

            int opcion = 0;
            while (opcion != 3)
            {
                Console.WriteLine("1.- Insertar Alumno");
                Console.WriteLine("2.- Mostrar TODOS");
                Console.WriteLine("3.- Mostrar Alumnas");
                Console.WriteLine("4.- INSENTAR TODOS");
                Console.WriteLine("5.- ORDENADO");
                Console.WriteLine("6.-  Salir");
                Console.WriteLine("Introduzca Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        LlenarArreglo(listaalumnos);
                        break;
                
                    default:
                        break;
                }
            }
        }
        static void LlenarArreglo(int[] arreglo, int n)
        {
            Random numero = new Random();
            for (int i = 0; i < n; i++)
                arreglo[i] = numero.Next(0, n);
        }
    }
}
