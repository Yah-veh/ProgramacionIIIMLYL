using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Aves
    {
        protected string nombre;
        protected double peso;
        protected double tamanioAlas;

        public Aves(string nombre, double peso, double tamanioAlas)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.tamanioAlas = tamanioAlas;
        }
        public override string ToString()
        {
            return "Nombre:" + nombre + " Peso:" + peso + " Tamaño de Alas:" + tamanioAlas;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public double getPeso()
        {
            return peso;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getTamanioAlas()
        {
            return tamanioAlas;
        }
        public void setTamanioAlas(double tamanioAlas)
        {
            this.tamanioAlas = tamanioAlas;
        }
    }
}
