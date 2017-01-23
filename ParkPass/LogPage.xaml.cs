﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class LogPage : ContentPage
	{
		private void Login_Clicked(object sender, System.EventArgs e)
		{

			//		await Navigation.PushAsync(new MainPage(), true);

		}

		async void NewAccount_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AccountPage(), true);
		}

		public LogPage()
		{
			
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false); 
		}
	}
}
