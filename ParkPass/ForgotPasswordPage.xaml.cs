using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class ForgotPasswordPage : ContentPage
	{
		public ForgotPasswordPage()
		{
			InitializeComponent();
		}

		void Reset_Password_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
