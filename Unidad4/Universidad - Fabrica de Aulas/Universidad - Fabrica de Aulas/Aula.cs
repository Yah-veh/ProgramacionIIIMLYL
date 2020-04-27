using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    abstract class Aula
    {
        protected String codigo;
        protected Ubicacion ubicacion;
        protected Tamanio tamanio;
        protected int CantidadPuestos;

        public void setDatos(string codigo, Ubicacion ubicacion, Tamanio tamanio, int cantidadPuestos)
        {
            this.codigo = codigo;
            this.ubicacion = ubicacion;
            this.tamanio = tamanio;
            CantidadPuestos = cantidadPuestos;
        }

        abstract public String getDatos();

    }
}
