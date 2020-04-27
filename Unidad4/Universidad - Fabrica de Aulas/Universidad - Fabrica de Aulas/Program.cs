using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaAulas fabricaaulas = new FabricaAulas();

            /* ---------------------------------------------------------------------------------------------------------------*/
            /* Creando Aula Teorica*/
            Aula A105 = fabricaaulas.getAula("Teoria", null);
            /* Cargando Datos Aula Teorica*/
            A105.setDatos("A105", new Ubicacion(0, 105), new Tamanio(3, 4), 30);


            /* ---------------------------------------------------------------------------------------------------------------*/
            /* Creando Aula Laboratorio*/
            List<Computadora> lc = new List<Computadora>();
            List<DiscoDuro> l = new List<DiscoDuro>();
            l.Add(new DiscoDuro("SeaGate", 6, MedidaCapacidad.Tb));
            Computadora c = new Computadora(Marca.Hp, "OMEN", new Procesador("Intel", 24), l, Color.negro, 2019);
            for (int i = 1; i <= 18; i++)
            {
                lc.Add((Computadora)c.Clone());

            }
            Aula A305 = fabricaaulas.getAula("Lab", lc);

            /* Cargando Datos Aula Teorica*/
            A305.setDatos("A305", new Ubicacion(2, 305), new Tamanio(4, 3), 28);
            /* ---------------------------------------------------------------------------------------------------------------*/



            /* Salida de Datos*/
            Console.WriteLine(A105.getDatos());
            Console.WriteLine(A305.getDatos());


            Console.ReadKey();
        }
    }
}
