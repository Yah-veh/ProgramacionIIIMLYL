using System;
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
    [Activity(Label = "ActividadMostrar")]
    public class ActividadMostrar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Mostrar);        

            TextView LugarVehiculo = FindViewById<TextView>(Resource.Id.txtMensajeAsignacionVehiculo);
            Button Aceptar = FindViewById<Button>(Resource.Id.btnAceptar);

            string mensaje = Intent.GetStringExtra("Lugar");

            LugarVehiculo.Text = mensaje;

            // Create your application here
        }
    }
}