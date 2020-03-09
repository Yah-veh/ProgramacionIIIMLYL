using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista[] ListaDeMesas = new Lista[4];
            InsertarTodos(ListaDeMesas);
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("1.- Lista de Mesas Ordenadas por Ciudad luego por mesa");
                Console.WriteLine("2.- ");
                Console.WriteLine("3.- ");
                Console.WriteLine("4.- ");

                Console.WriteLine("5.- Salir");
                Console.Write("Introduzca opcion ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CiudadMesa(ListaDeMesas);
                        break;
                    case 2:
                        JuntosMenor20(ListaDeMesas);
                        break;
                    case 3:
                        VotosDiputadosLapaz(ListaDeMesas);
                       
                        break;
                    default:
                        break;
                }
            }

        }
        static void InsertarTodos(Lista[] ListaDeMesas)
        {
            ListaDeMesas[0] = new Lista(41, "Presidente ", "Sucre ", 35, 46, 15, 5);
            ListaDeMesas[1] = new Lista(24, "Diputado ", "La Paz ", 33, 11, 20, 6);
            ListaDeMesas[2] = new Lista(13, "Diputado ", "Sucre ", 36, 60, 18, 78);
            ListaDeMesas[3] = new Lista(14, "Presidente ", "Sucre ", 40, 20, 20, 8);
        }
        public static void CiudadMesa(Lista[] listaDeMesas)
        {
            var CiudadyMesa = from l in listaDeMesas
                              orderby l.ciudad+l.mesa ascending
                               select l;
            foreach (Lista a in CiudadyMesa)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}{6}", a.mesa,a.eleccion,a.ciudad,a.mas,a.cc,a.juntos,a.crecer);
            }
            Console.ReadKey();
        }
        public static void JuntosMenor20(Lista[] ListaDeMesas)
        {
            var menor = from l in ListaDeMesas                   
                        where l.juntos < 20
                        orderby l.eleccion ascending
                        select l;

                        

            foreach (var a in menor)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}{6}", a.mesa,a.eleccion,a.ciudad,a.mas,a.cc,a.juntos,a.crecer);
            }
            Console.ReadKey();
        }
        public static void VotosDiputadosLapaz(Lista[] ListaDeMesas)
        {
            var cantidad = from l in ListaDeMesas
                           group l by l.ciudad into ciudad
                           select new { Ciudad = ciudad.Key, Cantidad = ciudad.Count() };

            foreach (var a in cantidad)
            {
                Console.WriteLine("{0} {1}", a.Ciudad,a.Cantidad);

            }
            Console.ReadKey();

        }

  
    }
}
