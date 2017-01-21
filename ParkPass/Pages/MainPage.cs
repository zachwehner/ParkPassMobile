// -----------------------------------------------------------------------
// <copyright file="MainPage.cs" company="Automated Transportation Network">
// Copyright (C) Automated Transportation Network All Rights Reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ParkPass.Models;

namespace ParkPass
{
	
	public class MainPage : MasterDetailPage
	{
		
		private MenuPage menuPage;
		public String parkNameValue { get; set;}
		ParkDetailsPage parkDetailsPage;

		public MainPage()
		{
			string MenuTextColor = "FFFFFF";
			menuPage = new MenuPage();


			ContentPage menupage = new ContentPage();

			var parkpassImage = new Image
			{
				Source = "ParkPassPreferred.png"


			};
			var accountButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Account.png",
				Text = "Account",
				HeightRequest = 40,
				WidthRequest = 250,
				FontSize = 24
			};
			accountButton.Clicked += Account_Clicked;

			var surveyButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Survey.png",
				Text = "  Surveys",
				HeightRequest = 40,
				WidthRequest = 200,
				FontSize = 24
			};
			surveyButton.Clicked += Survey_Clicked;

			var parksButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Tree.png",
				Text = "    Parks",
				HeightRequest = 40,
				WidthRequest = 200,
				FontSize = 24
			};
			parksButton.Clicked += Parks_Clicked;
			var settingButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Settings.png",
				Text = "  Settings",
				HeightRequest = 40,
				WidthRequest = 200,
				FontSize = 24
			};
			settingButton.Clicked += Settings_Clicked;

			var myPassesButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Passes.png",
				Text = "  Passes",
				HeightRequest = 40,
				WidthRequest = 200,
				FontSize = 24
			};
			myPassesButton.Clicked += MyPasses_Clicked;

			var signOutButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex(MenuTextColor),
				Image = "Signout.png",
				Text = "  Signout",
				HeightRequest = 40,
				WidthRequest = 200,
				FontSize = 24
			};
			signOutButton.Clicked += Signout_Clicked;

			menuPage.Content = new StackLayout
			{
				Margin = 0,
				Padding = 0,
				Spacing = 10,
				Children = { parkpassImage, accountButton, parksButton, myPassesButton, surveyButton, settingButton, signOutButton }
			};


			Master = menuPage;

			parkNameValue = "Please Choose A Park";


			NavigationPage.SetHasNavigationBar(this, false);

			parkDetailsPage = new ParkDetailsPage();
				// do something with id
			


			Detail = new NavigationPage(parkDetailsPage);
			NavigationPage.SetHasNavigationBar(this, false);

			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page,park) =>{
				
				parkDetailsPage.ToolbarItems[0].Text = park.Name;
			});
				
			menuPage.Title = "Parks";
		}

		/// <summary>
		/// Sets gesture enabled to true when main page appears.
		/// </summary>
		protected override void OnAppearing()
		{
			base.OnAppearing();
			menuPage.Title = parkNameValue;
		}

		/// <summary>
		/// Sets gesture enabled to false when main page disappears.
		/// </summary>
		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			menuPage.Title = parkNameValue;
			this.IsGestureEnabled = false;
		}

		/// <summary>
		/// Initializes a detail page of the type that was clicked.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">The event arguments.</param>
		private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			
			//var item = e.SelectedItem as NavigationDrawerItem;
			//item = new NavigationDrawerItem;
			//item.PageType = SelectParkPage;
			//if (item != null)
			//{
			//	if (item.PageType != typeof(LoginPage))
			//	{
			//		Detail = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
			//		navDrawerPage.ListView.SelectedItem = null;
			//		IsPresented = false;
			//	}
			//	else
			//	{
			//		AccountService.LogoutUser();
			//		App.Current.MainPage = new NavigationPage(new LoginPage(new AccountService()));
			//	}
			//}
		}
		public async void ParkName_Clicked()
		{
			var parkPage = new ParkPage();
			parkPage.BindingContext = MainPage.BindingContextProperty;

			await Navigation.PushModalAsync(parkPage);

			var x = parkPage.ParkNameValue2;

		}

		void HandleAction()
		{

		}

		public async void Account_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AccountPage)));
		
		}
		public async void Parks_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ParkDetailsPage)));

		}

		public async void Survey_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MySurveysPage)));

		}
		public async void Settings_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SettingsPage)));

		}
		public async void MyPasses_Clicked(object sender, System.EventArgs e)
		{
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ParkPassListPage)));

		}
		public async void Purchase_Clicked()
		{
			await Navigation.PushModalAsync(new ParkPassPage());

		}
		public async void Signout_Clicked(object sender, System.EventArgs e)
		{
	//		await Navigation.PushAsync(new LoginPage());

		}
	

	}
}
