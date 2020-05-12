using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Zoologico
    {
        protected string nombre;
        protected List<Jaula> jaulas;
        protected string direccion;
        protected int telefono;

        public Zoologico(string nombre, string direccion, int telefono)
        {
            this.nombre = nombre;
            jaulas = new List<Jaula>();
            this.direccion = direccion;
            this.telefono = telefono;
        }
        
    }
}
