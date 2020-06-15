using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Parqueo_Movil___Xamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button BotonIngresar = FindViewById<Button>(Resource.Id.btnIngresar);
            Button BotonSalida= FindViewById<Button>(Resource.Id.btnSalida);
            Button BotonMostrarVehiculoActuales = FindViewById<Button>(Resource.Id.btnActuales);
            Button BotonHistorial = FindViewById<Button>(Resource.Id.btnHistorial);

            BotonIngresar.Click += (sender, e) =>
            {
                var ingresar = new Intent(this, typeof(ActividadIngresar));
                StartActivity(ingresar);
            };

            BotonSalida.Click += (sender, e) =>
            {
                var salida = new Intent(this, typeof(ActividadSalida));
                StartActivity(salida);
            };

            BotonMostrarVehiculoActuales.Click += (sender, e) =>
            {
                var VehiculosActuales = new Intent(this, typeof(ActividadMostrarVehiculosActuales));
                StartActivity(VehiculosActuales);
            };

            BotonHistorial.Click += (sender, e) =>
            {
                var historial = new Intent(this, typeof(ActividadHistorial));
                StartActivity(historial);
            };



        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}