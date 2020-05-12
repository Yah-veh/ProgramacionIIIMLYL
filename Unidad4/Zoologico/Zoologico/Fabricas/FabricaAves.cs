using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FabricaAves : FabricaAbstracta
    {
        public Aves getAves(string Tipo, string nombre, double peso, double tamanioAlas)
        {
            switch (Tipo)
            {
                case "Aguila":
                    return new Aguila( nombre,  peso,  tamanioAlas);
                case "Condor":
                    return new Condor(nombre, peso, tamanioAlas);
                case "Loro":
                    return new Loro(nombre,  peso,  tamanioAlas);
                default:
                    return null;
            }
        }

        public Mamiferos getMamiferos(string Tipo, string nombre, double temperatura, int nroDePatas, Color color)
        {
            throw new NotImplementedException();
        }

        public Peces getPeces(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
