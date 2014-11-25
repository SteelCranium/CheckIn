
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
	[Activity (Label = "SignIn")]			
	public class SignIn : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.SignIn);



			// Set our view from the "main" layout resource

			#region Fields
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.signin);
			EditText email = FindViewById<EditText> (Resource.Id.email);
			EditText password = FindViewById<EditText> (Resource.Id.password);
			EditText phone = FindViewById<EditText> (Resource.Id.phone);

			#endregion

			button.Click += delegate {
				//TODO- Code what the login button does
				if(loginVerification()) {
					StartActivity(typeof(StudentPage));
					Finish();
				}

				// Create your application here
			};
		}

		public static bool loginVerification()
		{
			return true;
		}
	}
}

