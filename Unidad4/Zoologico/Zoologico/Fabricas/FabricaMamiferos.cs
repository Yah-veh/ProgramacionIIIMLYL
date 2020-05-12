using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FabricaMamiferos : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamanioAlas)
        {
            throw new NotImplementedException();
        }

        public Mamiferos getMamiferos(string Tipo, string nombre, double temperatura, int nroDePatas, Color color)
        {
            switch (Tipo)
            {
                case "Oso":
                    return new Oso( nombre,  temperatura,  nroDePatas,  color);
                case "Leon":
                    return new Oso(nombre, temperatura, nroDePatas, color);
                case "Mono":
                    return new Oso(nombre, temperatura, nroDePatas, color);
                default:
                    return null;
            }
        }

        public Peces getPeces(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
