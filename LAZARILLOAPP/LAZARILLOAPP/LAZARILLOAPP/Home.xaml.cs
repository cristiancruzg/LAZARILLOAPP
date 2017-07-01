using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace LAZARILLOAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
        {
            InitializeComponent();

            Localizar.Clicked += localizar_Clicked;
        }

        private async void localizar_Clicked(object sender, EventArgs e)
        {
            await RetreiveLocation ();
        }

        private  async Task RetreiveLocation ()
        {
            
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;

            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            Txtlat.Text = "latitud: "+position.Latitude.ToString();
            Txtlon.Text = "Longitud: "+position.Longitude.ToString();

            MyMap.MoveToRegion(
                                 MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),
                                 Distance.FromMeters(20)));
        }   
    }
}