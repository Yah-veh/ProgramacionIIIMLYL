using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    interface FabricaAbstracta
    {
        Documentos getDocumento(string tipo);
    }
}
