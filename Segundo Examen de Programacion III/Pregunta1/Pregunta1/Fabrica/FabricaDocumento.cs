using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class FabricaDocumento : FabricaAbstracta
    {

        public Documentos getDocumento(string tipo)
        {
            switch (tipo)
            {
                case "Carta":
                    return new Carta( );
                case "Circular":
                    return new Circular();
                case "Memorandum":
                    return new Memorandum();

                default:
                    return null;

            }
        }
    }
}
