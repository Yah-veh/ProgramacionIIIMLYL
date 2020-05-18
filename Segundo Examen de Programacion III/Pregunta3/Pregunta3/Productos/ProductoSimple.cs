using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class ProductoSimple:AbstracProducto
    {
        public ProductoSimple(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
          
        }


        public override double getPrecio()
        {
            return this.precio;
        }

  
    }
}
