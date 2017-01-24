using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class AccountPage : ContentPage
	{
		public AccountPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

		}
		async void CreateAccount_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new TempNavPage(), true);
		}

	}
}
