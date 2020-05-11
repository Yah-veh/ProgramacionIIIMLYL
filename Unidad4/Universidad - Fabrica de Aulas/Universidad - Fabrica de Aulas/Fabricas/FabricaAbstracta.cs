using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    interface FabricaAbstracta
    {
        Aula getAula(string Tipo, List<Computadora> lista);
    }
}
