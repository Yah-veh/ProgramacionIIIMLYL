﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad___Fabrica_de_Aulas
{
    class DiscoDuro
    {
        string marca;
        int capacidad;
        MedidaCapacidad medidacapacidad;

        public DiscoDuro(string marca, int capacidad, MedidaCapacidad medidacapacidad)
        {
            this.marca = marca;
            this.capacidad = capacidad;
            this.medidacapacidad = medidacapacidad;
        }
    }
    enum MedidaCapacidad
    {
        Mb, Gb, Tb

    }
}

