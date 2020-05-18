using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class OrdenCompra
    {
        private long idOrden;
        private String cliente;
        private Calendar fecha;
        private List<AbstracProducto> listaProductos;

        public OrdenCompra(long idOrden, string cliente)
        {
            this.idOrden = idOrden;
            this.cliente = cliente;
            listaProductos = new List<AbstracProducto>();
            
        }

        public long getidOrden()
        {
            return idOrden;
        }

        public void setidOrden(long idOrden)
        {
            this.idOrden = idOrden;
        }

        public String getCliente()
        {
            return cliente;
        }

        public void setCliente(String cliente)
        {
            this.cliente = cliente;
        }

        public Calendar getFecha()
        {
            return fecha;
        }

        public void setDateTime(Calendar fecha)
        {
            this.fecha = fecha;
        }

        public List<AbstracProducto> getProductos()
        {
            return listaProductos;
        }

        public void setProductos(List<AbstracProducto> listaproductos)
        {
            this.listaProductos = listaproductos;
        }

        public double getPrecio()
        {

            double precio = 0;
            foreach (AbstracProducto producto in listaProductos)
            {
                precio += producto.getPrecio();
            }
            return precio;
        }

        public void insertarProducto(AbstracProducto producto)
        {
            listaProductos.Add(producto);
        }

        public void eliminarProducto(AbstracProducto producto)
        {
            listaProductos.Remove(producto);
        }

        public void imprimirOrden()
        {

            Console.WriteLine("Numero de Orden:" + idOrden + " Nombre de Cliente:" + cliente);
            foreach (AbstracProducto producto in listaProductos)
            {

                Console.WriteLine("{0}               {1}", producto.getNombre(), producto.getPrecio());

            }
            Console.WriteLine("Total: {0} =============================================", getPrecio());
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}

