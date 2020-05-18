using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
     class Carta:Documentos
    {
        public override string ToString()
        {
            return "Carta"+ " Fecha:" + fecha + " Origen:" + origen + " Asunto" + asunto;
        }
    }
}
