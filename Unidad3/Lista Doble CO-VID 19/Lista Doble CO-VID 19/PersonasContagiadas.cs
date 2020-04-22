using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Doble_CO_VID_19
{
    class PersonasContagiadas
    {
        public PersonasContagiadas(string nombre, string apellido, int edad, string sexo, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
            Estado = estado;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }


        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Edad.ToString() + " " + Sexo + " " + Estado;
        }
    }
}
