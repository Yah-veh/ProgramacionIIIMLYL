using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class FabricaAulas:FabricaAbstracta
    {
        public Aula getAula(string Tipo, List<Computadora> lista)
        {
            switch (Tipo)
            {
                case "Teoria":
                    return new Teoria();
                case "Lab":
                    return new Laboratorio(lista);

                default:
                    return null;

            }
        }
    }
}
