using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LAZARILLOAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        private async void Localizar_Clicked(object sender,EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            await locator.StartLIstemingAsinc(5, 20);

            locator.PositionChanges += (cambio, args) =>
            {
                var loc = args.Position;
              
                
            };


        }
    }
}