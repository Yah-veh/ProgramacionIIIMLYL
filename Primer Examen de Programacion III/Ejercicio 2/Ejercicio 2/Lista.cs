using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Lista
    {
        public Lista(int mesa, string eleccion, string ciudad, int mas, int cc, int juntos, int crecer)
        {
            this.mesa = mesa;
            this.eleccion = eleccion;
            this.ciudad = ciudad;
            this.mas = mas;
            this.cc = cc;
            this.juntos = juntos;
            this.crecer = crecer;
        }

        public int mesa { set; get; }
        public string eleccion { set; get; }
        public string ciudad { set; get; }
        public int mas { set; get; }
        public int cc { set; get; }
        public int juntos { set; get; }
        public int crecer { set; get; }
    }
}
