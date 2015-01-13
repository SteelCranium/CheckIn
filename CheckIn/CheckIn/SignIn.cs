
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Provider;
using Android.Telephony;
using System.Text.RegularExpressions;
using Java.Util;

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
			login.Text = "";
			Button button = FindViewById<Button> (Resource.Id.signin);
			EditText email = FindViewById<EditText> (Resource.Id.email);
			EditText password = FindViewById<EditText> (Resource.Id.password);
			TelephonyManager telephonyManager = (TelephonyManager)this.GetSystemService(Context.TelephonyService);
			string id = telephonyManager.DeviceId;

			#endregion



			button.Click += delegate {
				//TODO- Code what the login button does
				login.Text = loginVerification(email, password, id);
				//if(loginVerification(email, password, id)) {
				//	StartActivity(typeof(StudentPage));
				//	Finish();
				//}
				//else {
					//login.Text = "Invalid Login Information";
				//}


			};
		}

		public static string loginVerification(EditText email, EditText password, string id)
		{

			var responseString = "";
			try
			{
				var request = (HttpWebRequest)WebRequest.Create("http://ewp.massivesoft.net/login.json");


				var postData = "email=" + email.Text + "&password=" + password.Text + "&id=" + id;
				var data = Encoding.ASCII.GetBytes(postData);

				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded";
				request.ContentLength = data.Length;

				using (var stream = request.GetRequestStream())
				{
					stream.Write(data, 0, data.Length);
				}

				var response = (HttpWebResponse)request.GetResponse();

				responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			}
			catch(Exception e) {
				return "fuck year";
			}

			Regex info = new Regex ("[{}\":,]+");

			responseString = info.Replace (responseString, " ");
			//string[] memes = responseString.Split (' ');
			return responseString;




		}


	}
}

