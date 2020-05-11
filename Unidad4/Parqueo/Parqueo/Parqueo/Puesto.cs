using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo
{
    class Puesto
    {
        int numero;
        Auto auto;
        DateTime inicio;
        DateTime fin;

        public Puesto(int numero)
        {
            this.numero = numero;
        }
        public string ingresasAuto(Auto auto)
        {
            this.auto = auto;
            this.inicio = DateTime.Now;
            return this.inicio.ToLongDateString();
        }
        public string salidaAuto(Auto auto)
        {
            this.auto = auto;
            this.fin = DateTime.Now;
            TimeSpan Total = fin - inicio;
            return Total.TotalHours;
        }
        public Boolean 

    }
}
