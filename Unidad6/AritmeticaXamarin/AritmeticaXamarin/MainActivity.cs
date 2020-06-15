using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Lang;
using Android.Content;
using System.Runtime.InteropServices;
using System;

namespace AritmeticaXamarin
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


            RadioGroup operaciones = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            EditText a = FindViewById<EditText>(Resource.Id.editTextA);
            EditText b = FindViewById<EditText>(Resource.Id.editTextB);
            Button BotonCalcular = FindViewById<Button>(Resource.Id.button1);
            TextView resultado = FindViewById<TextView>(Resource.Id.txtResultado);

            BotonCalcular.Click += (sender, e) => {

                int seleccionadoOperacionID = operaciones.CheckedRadioButtonId;
                RadioButton seleccionadoTipo = FindViewById<RadioButton>(seleccionadoOperacionID);   
                
                int A = Convert.ToInt32(a.Text);
                int B = Convert.ToInt32(b.Text);
                
                Aritmetica o = Aritmetica.getInstance();

                switch (seleccionadoOperacionID)
                {
                    case 2131230838:
              
                        resultado.Text = (o.Sumar(A, B).ToString());
                        break;
                    case 2131230839:
                        resultado.Text = (o.Restar(A, B).ToString());
                        break;
                    case 2131230840:
                        resultado.Text = (o.Multiplicar(A, B).ToString());
                        break;
                    case 2131230841:
                        resultado.Text = (o.Dividir(A, B).ToString());
                        break;
                    case 2131230842:
                        resultado.Text = (o.Potencia(A, B).ToString());
                        break;
                    case 2131230843:
                        resultado.Text = (o.Raiz(A, B).ToString());
                        break;
               
                }






            };

       




        }
   
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}