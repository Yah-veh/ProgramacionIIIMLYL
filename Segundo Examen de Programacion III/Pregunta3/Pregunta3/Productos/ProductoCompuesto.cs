using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class ProductoCompuesto:AbstracProducto
    {
        private List<AbstracProducto> productos = new List<AbstracProducto>();

        public ProductoCompuesto(String nombre)
        {
            this.nombre = nombre;

        }
        public void setPrice(double price)
        {

        }

        public void insertarProducto(AbstracProducto product)
        {
            this.productos.Add(product);
        }

        public bool eliminarProductos(AbstracProducto producto)
        {
            return this.productos.Remove(producto);
        }

        public override double getPrecio()
        {
            double precio = 0;
            foreach (AbstracProducto producto in productos)
            {
                precio += producto.getPrecio();
            }
            return precio;

        }

    }
}
