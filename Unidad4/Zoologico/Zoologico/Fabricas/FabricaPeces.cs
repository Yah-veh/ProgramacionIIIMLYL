using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FabricaPeces : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamanioAlas)
        {
            throw new NotImplementedException();
        }

        public Mamiferos getMamiferos(string Tipo, string nombre, double temperatura, int nroDePatas, Color color)
        {
            throw new NotImplementedException();
        }

        public Peces getPeces(string Tipo, string nombre, double longitud)
        {
            switch (Tipo)
            {
                case "Pacu":
                    return new Pacu( nombre,  longitud);
                case "Sabalo":
                    return new Sabalo(nombre, longitud);
        
                default:
                    return null;
            }
        }
    }
}
