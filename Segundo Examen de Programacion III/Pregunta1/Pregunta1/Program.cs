using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Pila<Documentos> p = new Pila<Documentos>();
            FabricaDocumento fabricadocumentos = new FabricaDocumento();

            while (opcion != 4)
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
                        Console.WriteLine("Tipo de Documento");
                        string tipo = Console.ReadLine();
                        Documentos c = fabricadocumentos.getDocumento(tipo);
                        Console.WriteLine("Fecha");
                        string fecha = Console.ReadLine();
                        Console.WriteLine("Origen");
                        string origen = Console.ReadLine();
                        Console.WriteLine("Asunto");
                        string asunto = Console.ReadLine();
                        Console.WriteLine("De");
                        string de = Console.ReadLine();
                        Console.WriteLine("Para");
                        string para = Console.ReadLine();
                        c.setDatos(fecha, origen, asunto, de, para);
                        p.push(c);
                        break;
                    case 2:
                        Documentos y = p.pop();
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
