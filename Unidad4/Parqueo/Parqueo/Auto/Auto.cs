using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo
{
    class Auto
    {
        Color color;
        Marca marca;
        Tipo tipo;
        string modelo;
        int anio;
        string placa;

        public Auto(Color color, Marca marca, Tipo tipo, string placa)
        {
            this.color = color;
            this.marca = marca;
            this.tipo = tipo;
            this.placa = placa;
        }

        public override string ToString()
        {
            return "Tipo:" + tipo.ToString() + " Color:" + color.ToString();
        }
    }
    enum Color
    { Morado,Rojo,Azul,Negro,Blanco,Otro}
    enum Marca
    { Toyota,Nissan,Suzuki,Ford,Kia}
    enum Tipo
    { Camioneta,Vagoneta,Auto,Camion,Motocicleta}
}
