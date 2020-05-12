using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Jaula
    {
        protected string animal;
        protected int alto;
        protected int ancho;
        protected int largo;

        public Jaula(string animal, int alto, int ancho, int largo)
        {
            this.animal = animal;
            this.alto = alto;
            this.ancho = ancho;
            this.largo = largo;
        }
        public string getAnimal()
        {
            return animal;
        }
        public void setLongitud(string animal)
        {
            this.animal = animal;
        }
        public int getAlto()
        {
            return alto;
        }
        public void setLongitud(int alto)
        {
            this.alto = alto;
        }
        public int getAncho()
        {
            return ancho;
        }
        public void setAncho(int ancho)
        {
            this.ancho = ancho;
        }
        public int getLargo()
        {
            return largo;
        }
        public void setLargo(int largo)
        {
            this.largo = largo;
        }
    }
}
