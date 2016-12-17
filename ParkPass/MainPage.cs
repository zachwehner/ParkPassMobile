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

		public MainPage()
		{
			
			menuPage = new MenuPage();
			Master = menuPage;
			parkNameValue = "Please Choose A Park";


			NavigationPage.SetHasNavigationBar(this, false);
			ParkDetailsPage parkDetailsPage = new ParkDetailsPage();
			//parkDetailsPage.ToolbarItems.Add(new ToolbarItem("Menu", "Hamburger_Menu.png", HandleAction, ToolbarItemOrder.Default, 0));
			parkDetailsPage.ToolbarItems.Add(new ToolbarItem(parkNameValue, null, ParkName_Clicked, ToolbarItemOrder.Default, 0));
			parkDetailsPage.ToolbarItems.Add(new ToolbarItem("Purchase", "purchase.png", Purchase_Clicked, ToolbarItemOrder.Default, 0));
			Detail = new NavigationPage(parkDetailsPage);
			NavigationPage.SetHasNavigationBar(this, false);

			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page,park) =>{
				
				parkDetailsPage.ToolbarItems[0].Text = park.Name;
			});
				
			menuPage.Title = "Parks";

			//navDrawerPage.ListView.ItemSelected += OnItemSelected;

		//	MessagingCenter.Subscribe<ContentPage>(this, MessageEventNames.SetMasterPageGestureEnabledFalse, (sender) =>
		//	{
		//		this.IsGestureEnabled = false;
		//	});
		}

		/// <summary>
		/// Sets gesture enabled to true when main page appears.
		/// </summary>
		protected override void OnAppearing()
		{
			base.OnAppearing();
			menuPage.Title = parkNameValue;


			//this.IsGestureEnabled = true;
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

		public async void Purchase_Clicked()
		{
			await Navigation.PushModalAsync(new ParkPassPage());

		}
	}
}
