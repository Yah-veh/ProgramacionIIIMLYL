using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Parqueo_Movil___Xamarin
{
    [Activity(Label = "ActividadIngresar")]
    public class ActividadIngresar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Ingreso);
            // Create your application here

            RadioGroup RadioGrupoTipoDeVehiculo = FindViewById<RadioGroup>(Resource.Id.RadioGroupTipoDeVehiculo);
            RadioGroup RadioGrupoColor = FindViewById<RadioGroup>(Resource.Id.RadioGroupColorDeVehiculo);
            RadioGroup RadioGrupoMarca = FindViewById<RadioGroup>(Resource.Id.radioGroupMarcaDeVehiculo);
            EditText NumPlaca= FindViewById<EditText>(Resource.Id.editTxtPlacaDeIngreso);
            Button BotonIngreso= FindViewById<Button>(Resource.Id.BtnDeIngreso);


            BotonIngreso.Click += (sender, e) =>
            {               
                int seleccionadoTipoID = RadioGrupoTipoDeVehiculo.CheckedRadioButtonId;
                RadioButton seleccionadoTipo= FindViewById<RadioButton>(seleccionadoTipoID);
                Tipo tipo;
                string strTipo = seleccionadoTipo.Text;
                Enum.TryParse(strTipo, out tipo);

                int seleccionadoColorID = RadioGrupoTipoDeVehiculo.CheckedRadioButtonId;
                RadioButton seleccionadoColor = FindViewById<RadioButton>(seleccionadoColorID);
                Color color;
                string strColor = seleccionadoColor.Text;
                Enum.TryParse(strColor, out color);


                int seleccionadoMarcaID = RadioGrupoTipoDeVehiculo.CheckedRadioButtonId;
                RadioButton seleccionadoMarca = FindViewById<RadioButton>(seleccionadoMarcaID);
                Marca marca;
                string strMarca = seleccionadoMarca.Text;
                Enum.TryParse(strMarca, out marca);

                string Placa = NumPlaca.Text;

                string lugar = Parqueo.getInstancia().ingresarAuto(color, marca, tipo, Placa);

                var lugr = new Intent(this, typeof(ActividadMostrar));
                lugr.PutExtra("Lugar", lugar);
                StartActivity(lugr);
            };
        }
    }
}