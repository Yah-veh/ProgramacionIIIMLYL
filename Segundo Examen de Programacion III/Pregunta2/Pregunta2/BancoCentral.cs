using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class BancoCentral
    {
        private static BancoCentral instance;
        List<string> a = new List<string>();

        private BancoCentral()
        {

        }
        public static BancoCentral getInstance()
        {
            if (instance == null)
            {
                instance = new BancoCentral();
                return instance;
            }
            else
                return instance;

        }
        public void ingresarFecha( string fecha)
        {
            a.Add(fecha);
        }
        public void Mostrar()
        {
            foreach( string o in a)
            {
                if ((o == "18/05/2020") | (o == "19/05/2020") | (o == "20/05/2020") | (o == "21/05/2020") | (o == "22/05/2020") | (o == "23/05/2020") | (o == "24/05/2020")
                    | (o == "25/05/2020") | (o == "26/05/2020") | (o == "27/05/2020") | (o == "28/05/2020") | (o == "29/05/2020") | (o == "30/05/2020"))
                {
                    Console.WriteLine("El Precio del Dolar para la fecha {0} es de 6.97", o);
                }
                else
                    Console.WriteLine("No se encuentra cotizacion de dolar para la fecha {0}", o);
            }
          
                

        }
    }
}
