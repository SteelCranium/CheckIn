
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
	[Activity (Label = "AdminPage")]			
	public class AdminPage : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Admin_Page);

			// Get our button from the layout resource,
			// and attach an event to it
			Button existing = FindViewById<Button> (Resource.Id.myButton);
			Button createnew = FindViewById<Button> (Resource.Id.Button1);

			existing.Click += delegate {
				StartActivity(typeof(AdminManage));
				Finish();
			};

			createnew.Click += delegate {
				StartActivity(typeof(AdminCreate));
				Finish();
			};
		}
	}
}

