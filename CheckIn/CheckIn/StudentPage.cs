
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

namespace CheckIn
{
	[Activity (Label = "StudentPage")]			
	public class StudentPage : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			SetContentView (Resource.Layout.Student_Page);


			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				Finish();
			};
		}
	}
}

