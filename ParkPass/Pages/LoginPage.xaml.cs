using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class LoginPage : ContentPage
	{
		private async void Login_Clicked(object sender, System.EventArgs e)
		{

			await Navigation.PushAsync(new MainPage(), true);
		
		}



		public LoginPage()
		{
			InitializeComponent();
		}
	}
}
