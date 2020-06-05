using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Security;

namespace Factorial___Xamarin
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
            EditText A = FindViewById<EditText>(Resource.Id.editText1);
            Button calcular = FindViewById<Button>(Resource.Id.button1);
            TextView Resultado = FindViewById<TextView>(Resource.Id.txtResultado);


            calcular.Click += (sender, e) =>
            {

                int a = int.Parse(A.Text);
                Resultado.Text = (Factorial(a)).ToString();
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i=1;i<=n;i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}