using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_de_Rentistas
{
    class Rentista
    {
        public Rentista(string nombre, string apellido, string sexo, int edad, string sector)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Edad = edad;
            Sector = sector;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Sector { get; set; }


        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Sexo + " " + Edad.ToString() + " " + Sector;
        }
    }
}
