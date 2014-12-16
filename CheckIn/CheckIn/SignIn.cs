
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
using System.Text.RegularExpressions;

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
			TextView login = FindViewById<TextView> (Resource.Id.login);
			Button button = FindViewById<Button> (Resource.Id.signin);
			EditText email = FindViewById<EditText> (Resource.Id.email);
			EditText password = FindViewById<EditText> (Resource.Id.password);

			#endregion



			button.Click += delegate {
				//TODO- Code what the login button does
				if(loginVerification(email, password)) {
					StartActivity(typeof(StudentPage));
					Finish();
				}
				else {

				}


			};
		}

		public static bool loginVerification(EditText email, EditText password)
		{
			Regex reg = new Regex(@"^\S+@\S+\.\S+");

			return (reg.IsMatch (email.Text) ? true : false);

		}


	}
}

