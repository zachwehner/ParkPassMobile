using System.Collections.Generic;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class App : Application
	{
		public string ParkName;

		public App()
		{
			
			InitializeComponent();
			MainPage = new NavigationPage(new LoginPage());
			//MainPage = new NavigationPage(new MenuPage());
			//MainPage = new NavigationPage(new HomePage());
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
