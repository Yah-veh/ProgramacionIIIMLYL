using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
     class Circular:Documentos
    {
  
        public override string ToString()
        {
            return "Circular"+ " De:"+de+ " Fecha:" + fecha + " Para:" + para + " Asunto" + asunto;
        }

    }
}
