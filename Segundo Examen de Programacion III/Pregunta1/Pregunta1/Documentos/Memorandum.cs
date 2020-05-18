using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
     class Memorandum:Documentos
    {
        public override string ToString()
        {
            return " Memorandum " +"Fecha:" + fecha +  " Asunto:" + asunto +" Para:" + para ;
        }
    }
}
