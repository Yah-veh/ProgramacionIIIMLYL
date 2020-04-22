using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class University
    {
        string Nombre;
        int Nit;
        TipoUniversidad tipoUniversidad;
        string URL;
        static University Instancia;

        public void setDatos(string nombre, int nit, TipoUniversidad tipoUniversidad, string uRL)
        {
            Nombre = nombre;
            Nit = nit;
            this.tipoUniversidad = tipoUniversidad;
            URL = uRL;
        }
        public string getDatos()
        {
            return "Nombre" + Nombre + "Nit" + Nit + "Tipo de Universidad" + tipoUniversidad + "URL" + URL;
        }
        public static University getInstancia()
        {
            if (Instancia==null)
            {
                Instancia = new University();
            }
            return Instancia;
        }
    }
    enum TipoUniversidad
    {
        publica,
        Privada
    }
}
