using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Lang;
using System;
using Android.Content;

namespace Pregunta3
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

            EditText Titulo = FindViewById<EditText>(Resource.Id.editTitulo);
            EditText Autor = FindViewById<EditText>(Resource.Id.editAutor);
            EditText Editorial = FindViewById<EditText>(Resource.Id.editEditorial);
            Button agregar = FindViewById<Button>(Resource.Id.btnAgregar);
            Button hisorial = FindViewById<Button>(Resource.Id.btnHistorial);
            TextView salida = FindViewById<TextView>(Resource.Id.txtSalida);
            RadioGroup RGestado = FindViewById<RadioGroup>(Resource.Id.radioGroup1);

            Biblioteca o = Biblioteca.getInstance();
            
            int seleccionadoEsetadoID = RGestado.CheckedRadioButtonId;
            

            agregar.Click += (sender, e) =>
            {
                switch(seleccionadoEsetadoID)
                {
                    case 2131230840:
                        
                        Libro a = new Libro(Titulo.Text, Autor.Text, Editorial.Text, "Nuevo");
                        o.InsentarLibro(a);
                        salida.Text = "Libro Agregado";
                        break;
                    case 2131230841:
                         a = new Libro(Titulo.Text, Autor.Text, Editorial.Text, "Seminuevo");
                        o.InsentarLibro(a);
                        salida.Text = "Libro Agregado";
                        break;
                    case 2131230842:
                         a = new Libro(Titulo.Text, Autor.Text, Editorial.Text, "Viejo");
                        o.InsentarLibro(a);
                        salida.Text = "Libro Agregado";
                        break;
                }               
            };
            hisorial.Click += (sender, e) =>
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