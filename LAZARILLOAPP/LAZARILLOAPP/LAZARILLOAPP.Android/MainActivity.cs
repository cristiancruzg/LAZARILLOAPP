using System;

using Android.App;
using Android.Content.PM;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LAZARILLOAPP.Droid
{
	[Activity (Label = "LAZARILLOAPP", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.Activity
	{
        private Textview _placeNameTextView;
       

		protected override void OnCreate (Bundle bundle)
		{
			
            
			base.OnCreate (bundle);
            
            
		}
	}
}

