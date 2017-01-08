using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage()
		{
			InitializeComponent();
		}

		private void ReturnToLogin()
		{
			Navigation.PopAsync(true);
		}
	}
}
