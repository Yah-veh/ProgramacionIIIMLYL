﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Parqueo_Movil___Xamarin
{
    class ProxyPuestos:IPuesto
    {
        private List<string> historial;

        private Puesto puesto;

        public ProxyPuestos(int numero)
        {
            puesto = new Puesto(numero);
            historial = new List<string>();
        }

        public string ingresarAuto(Auto auto)
        {
            historial.Add(DateTime.Now.ToLongDateString() + " esta  ingresando el auto " + auto);
            return puesto.ingresarAuto(auto);
        }

        public double salirAuto()
        {
            historial.Add(DateTime.Now.ToLongDateString() + " esta  saliendo el auto " + puesto.getAuto());
            return puesto.salirAuto();
        }
        public string[] getHitorial()
        {
            string[] h = historial.ToArray();
            return h;
        }

        public bool estaOcupado()
        {
            return puesto.estaOcupado();
        }

        public Auto getAuto()
        {
            return puesto.getAuto();
        }
    }

}