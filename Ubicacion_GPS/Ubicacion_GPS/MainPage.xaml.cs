using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Ubicacion_GPS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLatitud.Text, out double latitud))
                return;
            if (!double.TryParse(txtLongitud.Text, out double longitud))
                return;
            await Map.OpenAsync(latitud, longitud, new MapLaunchOptions
            {

                Name = txtNombreUbicacion.Text,
                NavigationMode = NavigationMode.None


            });


    } }
}
