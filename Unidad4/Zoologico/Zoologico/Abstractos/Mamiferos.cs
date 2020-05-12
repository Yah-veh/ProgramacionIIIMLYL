using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Mamiferos
    {
        protected string nombre;
        protected double temperatura;
        protected int nroDePatas;
        protected Color color;

        public Mamiferos(string nombre, double temperatura, int nroDePatas, Color color)
        {
            this.nombre = nombre;
            this.temperatura = temperatura;
            this.nroDePatas = nroDePatas;
            this.color = color;
        }
        public override string ToString()
        {
            return "Nombre:" + nombre + " Temperatura:" + temperatura + " Numero de Patas:" + nroDePatas + " Color:" + color;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public double getTemperatura()
        {
            return temperatura;
        }
        public void setTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public int getNroDePatas()
        {
            return nroDePatas;
        }
        public void setNroDePatas(int nroDePatas)
        {
            this.nroDePatas = nroDePatas;
        }
        public Color getColor()
        {
            return color;
        }
        public void setColor(Color color)
        {
            this.color = color;
        }
    }
    enum Color
    { rojo,amarillo,azul,verde,morado,blanco}
}
