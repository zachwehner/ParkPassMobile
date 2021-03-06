﻿using System.Collections.Generic;
using Xamarin.Forms;
using System;
using ParkPass.Views;

namespace ParkPass
{
	public partial class App : Application
	{

		public static ParkManager ParkManager { get; private set; }
		public static IDisplaySettings DisplaySettings { get; private set; }
		public static AccessToken UserToken { get; set; }
		public static IUserPreferencesStore UserPreferencesStore { get; private set; }

		public static void Init(IDisplaySettings displaySettings)
		{
			App.DisplaySettings = displaySettings;
		}

		public App(IUserPreferencesStore userPreferencesStore)
		{

			InitializeComponent();
			ParkManager = new ParkManager(new ParkService());

			App.UserPreferencesStore = userPreferencesStore;
			//var token = UserContext.GetAccessToken();
			//if (token != null && !token.IsExpired)
			//{
			//	App.Current.MainPage = new NavigationPage(new TempNavPage());
			//}
			//else
			//{
			//	App.Current.MainPage = new NavigationPage(new LogPage(null));
			//}


			//MainPage = new NavigationPage(new HelpfulNumbersPage());
			NavigationPage.SetHasNavigationBar(this, false);
			MainPage = new NavigationPage(new LogPage(null));
			//MainPage = new NavigationPage(new PaymentPage());
		//	MainPage = new NavigationPage(new ParkPass.Views.CarouselPage(CarouselLayout.IndicatorStyleEnum.Dots));
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
