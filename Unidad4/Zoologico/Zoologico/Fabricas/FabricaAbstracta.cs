using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    interface FabricaAbstracta
    {
        Mamiferos getMamiferos(string Tipo, string nombre, double temperatura, int nroDePatas, Color color);
        Aves getAves(string Tipo, string nombre, double peso, double tamanioAlas);
        Peces getPeces(string Tipo, string nombre, double longitud);

    }
}
