using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class Teoria :Aula
    {
        List<string> pupitres;
        public override string getDatos()
        {
            return "Aula de Teoria: " + codigo + " Ubicacion: " + ubicacion;

        }
    }
}
