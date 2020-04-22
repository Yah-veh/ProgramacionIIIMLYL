using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Celular
{
    class Celular
    {
        Marca marca;
        string Modelo;
        TamanioPantalla tamaniopantalla;
        Color color;
        int memoria;
        Procesador procesador;

        public Celular(Marca marca, string modelo, TamanioPantalla tamaniopantalla, Color color, int memoria, Procesador procesador)
        {
            this.marca = marca;
            Modelo = modelo;
            this.tamaniopantalla = tamaniopantalla;
            this.color = color;
            this.memoria = memoria;
            this.procesador = procesador;
        }
        public override string ToString()
        {
            return " Marca:"+ marca + " Modelo:"+Modelo + " Tamaño de Pantalla:"+tamaniopantalla +" Color:"+ color + " Memoria:"+ memoria + " Procesador:"+procesador;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
    enum Marca
    {
        Samsung, Huawei, LG, Sonny
    } 
    enum Color
    {
        Negro, Rojo, Celeste, Blanco, Azul
    }

    

}
