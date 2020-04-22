using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular c = new Celular(Marca.Samsung, "A20", new TamanioPantalla(15, 8), Color.Blanco, 32, new Procesador("Intel", 8, 2));
            Celular c2 = (Celular)c.Clone();
            Celular c3 = (Celular)c.Clone();
            Celular c4 = (Celular)c.Clone();
            Celular c5 = (Celular)c.Clone();
            Console.WriteLine(c+"\n"+ c2 + "\n" +c3+ "\n"+ c4, "\n"+ c5+ "\n");
            Console.ReadKey();
        }
    }
}
