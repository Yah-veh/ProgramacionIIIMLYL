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

namespace Pregunta3
{
    [Activity(Label = "ActividadHistorial")]
    public class ActividadHistorial : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Historial);
            // Create your application here
            Biblioteca o = Biblioteca.getInstance();

            TextView Historial = FindViewById<TextView>(Resource.Id.txtSalidaHistorial);

            Historial.Text = o.MostrarLibros();
           
        }
    }
}