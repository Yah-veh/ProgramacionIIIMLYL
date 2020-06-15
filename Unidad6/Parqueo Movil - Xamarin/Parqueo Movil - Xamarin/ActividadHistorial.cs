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
    [Activity(Label = "ActividadHistorial")]
    public class ActividadHistorial : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Historial);
            // Create your application here
            ListView ListaHistorial = FindViewById<ListView>(Resource.Id.ListViewHistorial);
            Button BotonAceptarHistorial = FindViewById<Button>(Resource.Id.btnAceptarHistorial);
            EditText numerohistorial = FindViewById<EditText>(Resource.Id.editTextHistorial);

            BotonAceptarHistorial.Click += (sender, e) =>
            {
                int n = Convert.ToInt32(numerohistorial.Text);
                string[] resultado = Parqueo.getInstancia().getHistorial(n);
                ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, resultado);
                ListaHistorial.Adapter = adapter;
            };

        }
    }
}