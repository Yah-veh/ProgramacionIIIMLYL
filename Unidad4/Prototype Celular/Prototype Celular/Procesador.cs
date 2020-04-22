using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Celular
{
    class Procesador
    {
        String Marca;
        int CantidadDeNucleos;
        double Frecuencia;

        public Procesador(string marca, int cantidadDeNucleos, double frecuencia)
        {
            Marca = marca;
            CantidadDeNucleos = cantidadDeNucleos;
            Frecuencia = frecuencia;
        }

        public override string ToString()
        {
            return Marca + CantidadDeNucleos.ToString() + Frecuencia.ToString();
        }
    }
}
