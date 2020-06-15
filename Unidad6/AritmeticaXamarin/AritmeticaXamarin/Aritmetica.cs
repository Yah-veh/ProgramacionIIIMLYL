using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AritmeticaXamarin
{
     class Aritmetica
    {
        Tipo tipo;
        enum Tipo
        {
            Sumar,Restar,Multiplicar,Dividir,Potencia,Raiz
        }
        
        private static Aritmetica instance;
        private Aritmetica()
        {

        }
        public static Aritmetica getInstance()
        {
            if (instance == null)
            {
                instance = new Aritmetica();
            }
            return instance;
        }


        public double Sumar(int a, int b)
        {
            return a + b;

        }
        public double Restar(int a, int b)
        {
            return a - b;

        }
        public double Multiplicar(int a, int b)
        {
            return a * b;

        }
        public double Dividir(int a, int b)
        {
            return a / b;

        }
        public double Potencia(int a, int b)
        {
            return Math.Pow(a, b);
        }
        public double Raiz(int a, int b)
        {
            return Math.Pow(a, (1 / b));

        }
    }
}