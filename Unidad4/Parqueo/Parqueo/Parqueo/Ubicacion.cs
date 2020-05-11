using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo
{
    class Ubicacion
    {
        string calle;
        int numero;

        public Ubicacion(string calle, int numero)
        {
            this.calle = calle;
            this.numero = numero;
        }
    }
}
