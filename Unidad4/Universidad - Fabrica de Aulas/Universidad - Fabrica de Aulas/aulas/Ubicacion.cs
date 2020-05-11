using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class Ubicacion
    {
        int piso;
        int nroaula;

        public Ubicacion(int piso, int nroaula)
        {
            this.piso = piso;
            this.nroaula = nroaula;
        }

        public override string ToString()
        {
            return "Piso "+ piso.ToString() + " Numero de Aula: " +nroaula.ToString();
        }
    }
}
