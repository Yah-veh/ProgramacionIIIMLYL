using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoSimple cerveza = new ProductoSimple("Cerveza", 20);
            ProductoSimple whisky = new ProductoSimple("Whisky", 120);
            ProductoSimple ron = new ProductoSimple("Ron", 60);
            ProductoSimple cocacola = new ProductoSimple("Coca Cola", 15);

            /* Caja de Cerveza que compone de 12 botellas*/
            ProductoCompuesto cajaCerveza = new ProductoCompuesto("Caja de Cerveza");
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);
            cajaCerveza.insertarProducto(cerveza);


            /*Combo Carnavalero*/
            ProductoCompuesto carnavalero = new ProductoCompuesto("Combo Carnavalero");
            carnavalero.insertarProducto(cocacola);
            carnavalero.insertarProducto(ron);


            OrdenCompra venta = new OrdenCompra(1, "Yerson");
            venta.insertarProducto(carnavalero);
            venta.insertarProducto(whisky);
            venta.imprimirOrden();

            OrdenCompra venta1 = new OrdenCompra(2, "Carlos");
            venta1.insertarProducto(cajaCerveza);
            venta1.insertarProducto(cocacola);
            venta1.imprimirOrden();

            OrdenCompra venta2 = new OrdenCompra(3, "Camila");
            venta2.insertarProducto(ron);
            venta2.insertarProducto(ron);
            venta2.insertarProducto(ron);
            venta2.insertarProducto(whisky);
            venta2.insertarProducto(cerveza);
            venta2.insertarProducto(cerveza);
            venta2.insertarProducto(cerveza);
            venta2.insertarProducto(cocacola);
            venta2.insertarProducto(cocacola);
            venta2.insertarProducto(cocacola);
            venta2.imprimirOrden();
            Console.ReadKey();

        }
    }
}
