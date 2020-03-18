using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lista_de_Alumos
{
    class Alumno
    {
        public Alumno(string nombre, string primerapellido, string segundoapeliido, string ci, int edad, string sexo)
        {
            this.nombre = nombre;
            this.primerapellido = primerapellido;
            this.segundoapeliido = segundoapeliido;
            this.ci = ci;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string nombre { set; get; }
        public string primerapellido { set; get; }
        public string segundoapeliido { set; get; }
        public string ci { set; get; }
        public int edad { set; get; }
        public string sexo { set; get; }

    }
}
