using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class TempNavPage : ContentPage
	{
		string welcometext;

		public TempNavPage()
		{
			InitializeComponent();
			welcomeLabel.Text = "Welcome " + App.UserToken.UserName.ToString();
		}

		async void Profile_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ProfilePage());
		}

		async void  ParkPassSelected_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ParkDetails3Page());
		}

		async void MyPasses(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ParkPassListPage());
		}
	}
}
