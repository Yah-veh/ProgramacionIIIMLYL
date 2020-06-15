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
    [Activity(Label = "ActividadSalida")]
    public class ActividadSalida : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Salida);
            // Create your application here

            EditText PlacaSalida = FindViewById<EditText>(Resource.Id.editxtPlacaDeSalida);
            TextView CostoSalida = FindViewById<TextView>(Resource.Id.txtCostoDeSalida);
            Button BotonSalida = FindViewById<Button>(Resource.Id.btnSalida);
            BotonSalida.Click += (sender, e) =>
            {
                CostoSalida.Text = Parqueo.getInstancia().SalirAuto(PlacaSalida.Text);
            };

        }
    }
}