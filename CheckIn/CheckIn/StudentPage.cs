
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Locations;

namespace CheckIn
{
	[Activity (Label = "StudentPage")]			
	public class StudentPage : Activity, ILocationListener
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			LocationManager stuLoc;

			SetContentView (Resource.Layout.Student_Page);


			Button button = FindViewById<Button> (Resource.Id.myButton);
			TextView textLocation = FindViewById<TextView> (Resource.Id.text);

			#region Location Services
			stuLoc = GetSystemService (Context.LocationService) as LocationManager;

			string Provider = LocationManager.GpsProvider;

			if(stuLoc.IsProviderEnabled(Provider))
			{
				stuLoc.RequestLocationUpdates(Provider, 2000, 1, this);
				Location loc = stuLoc.GetLastKnownLocation(Provider);
				textLocation.Text = "Latitude:" + loc.Latitude + "\nLongitude:" + loc.Longitude + "";
			} 
			else 
			{

			}




			#endregion
			button.Click += delegate {
				Finish();
			};
		}

		public void OnProviderEnabled (string provider)
		{
			return;
		}
		public void OnProviderDisabled (string provider)
		{
				//Change the text to say that location services are disabled
			return;
		}
		public void OnStatusChanged (string provider, Availability status, Bundle extras)
		{
			return;
		}
		public void OnLocationChanged (Android.Locations.Location location)
		{
			//Check to see if the user is still at the location
			return;
		}
	}
}

