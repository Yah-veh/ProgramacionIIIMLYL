using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Oso : Mamiferos
    {
        public Oso(string nombre, double temperatura, int nroDePatas, Color color) : base(nombre, temperatura, nroDePatas, color)
        {
        }
    }
}
