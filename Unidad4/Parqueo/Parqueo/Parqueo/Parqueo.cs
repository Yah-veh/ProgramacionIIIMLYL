using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo
{
    class Parqueo
    {
        string nombre;
        Ubicacion ubicacion;
        double Costo;
        int capacidad;
        Puesto[] puesto;

        public Parqueo(string nombre, Ubicacion ubicacion, double costo, int capacidad)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            Costo = costo;
            this.capacidad = capacidad;
            this.puesto = new Puesto[capacidad];
            for (int i=0;i<this.puesto.Count();i++)
            {
                this.puesto[i] = new Puesto(i);
            }
        }
        private int getIndicePuesto()
        {

        }
        public void ingresarAuto(Color color, Marca marca, Tipo tipo, string placa)
        {
            Auto auto = new Auto(color,marca,tipo,placa);
        }
    }
}
