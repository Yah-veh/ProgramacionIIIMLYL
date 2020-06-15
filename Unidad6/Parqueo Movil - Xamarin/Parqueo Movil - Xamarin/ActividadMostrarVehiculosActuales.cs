using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Parqueo_Movil___Xamarin
{
    [Activity(Label = "ActividadMostrarVehiculo")]
    public class ActividadMostrarVehiculosActuales : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MostrarVehiculosActuales);

            RecyclerView LugarVehiculo = FindViewById<RecyclerView>(Resource.Id.recyclerMostrarActuales);


            LinearLayoutManager manager = new LinearLayoutManager(this);
            LugarVehiculo.SetLayoutManager(manager);

            
         



            // Create your application here
        }
    }
}