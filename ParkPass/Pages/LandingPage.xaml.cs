using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class LandingPage : ContentPage
	{
		public LandingPage()
		{
			InitializeComponent();
		}

		void OnNationalParksTapped(object sender, EventArgs args)
		{
			var imageSender = (Image)sender;
			// Do something
			DisplayAlert("Alert", "Tap gesture recognised", "OK");
		}
		void OnSportingEventsTapped(object sender, EventArgs args)
		{
			var imageSender = (Image)sender;
			// Do something
			DisplayAlert("Alert", "Tap gesture recognised", "OK");
		}
		void OnThemeParksTapped(object sender, EventArgs args)
		{
			var imageSender = (Image)sender;
			// Do something
			DisplayAlert("Alert", "Tap gesture recognised", "OK");
		}
	}


}
