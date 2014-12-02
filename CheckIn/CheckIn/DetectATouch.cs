
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
	[Activity(Label = "DetectATouch", MainLauncher = true)]
	public class Activity1 : Activity, View.IOnTouchListener
	{
		private Button _myButton;
		private float _viewX;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
			_myButton = FindViewById<Button>(Resource.Id.button1);
			_myButton.SetOnTouchListener(this);
		}
		public bool OnTouch(View v, MotionEvent e)
		{
			switch (e.Action)
			{
			case MotionEventActions.Down:
				_viewX = e.GetX();
				break;
			case MotionEventActions.Move:
				var left = (int) (e.RawX - _viewX);
				var right = (int) (left + v.Width);
				v.Layout(left, v.Top, right, v.Bottom);
				break;
			}
			return true;
		}
	}
}

