using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class Procesador
    {
        string marca;
        int frecuencia;

        public Procesador(string marca, int frecuencia)
        {
            this.marca = marca;
            this.frecuencia = frecuencia;
        }

        public override string ToString()
        {
            return "Marca: "+marca + " " + frecuencia.ToString() + "Ghz ";
        }
    }
}
