using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Juan = new Persona();

            University univalle = new University();
            univalle.setDatos("Nombre", 123456789, TipoUniversidad.Privada, "www.xvideos.com");
            univalle.getDatos();
            Console.ReadKey();


        }
    }
}
