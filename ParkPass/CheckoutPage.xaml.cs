using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class CheckoutPage : ContentPage
	{
		public CheckoutPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var barcodePage = new BarcodePage();
			Navigation.PopModalAsync();
			Navigation.PushModalAsync(barcodePage);

		}
	}
}
