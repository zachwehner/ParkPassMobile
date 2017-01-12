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
			//MainPage = new NavigationPage(new HelpfulNumbersPage());
			NavigationPage.SetHasNavigationBar(this, false);
			// MainPage = new NavigationPage(new HelpfulNumbersPage());
	//		MainPage = new NavigationPage(new TestPage());
		MainPage = new NavigationPage(new LoginPage());
		//	MainPage = new NavigationPage(new SignUpPage());
		//	MainPage = new NavigationPage(new MainPage());
		//		MainPage = new NavigationPage(new ParkPassListPage());
			//MainPage = new NavigationPage(new BarcodePage());
			NavigationPage.SetHasNavigationBar(this, false);
		}

	public void ClearNavigationAndGoToPage(ContentPage page)
	{
		MainPage = new NavigationPage(new MainPage());
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
