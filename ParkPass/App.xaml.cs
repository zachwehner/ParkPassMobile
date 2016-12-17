using System.Collections.Generic;
using Xamarin.Forms;
using System;
namespace ParkPass
{
	public partial class App : Application
	{


		public App()
		{
			InitializeComponent();

			NavigationPage.SetHasNavigationBar(this, false);
			MainPage = new NavigationPage(new MainPage());
			NavigationPage.SetHasNavigationBar(this, false);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}


	}
}
