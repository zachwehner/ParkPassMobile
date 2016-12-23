using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class MenuPage : ContentPage
	{
		public string ParkNameValue;
	
	

		public MenuPage()
		{
			
		//	this.ToolbarItems.Add(new ToolbarItem("Purchase", "purchase.png", HandleAction, ToolbarItemOrder.Default, 0));

			InitializeComponent();

		}

		void HandleAction()
		{
			Navigation.PushAsync(new AccountPage());
		}


		void Accounts_Clicked(object sender, System.EventArgs e)
		{
			new MainPage().Detail.Navigation.PushAsync(new AccountPage());
			throw new NotImplementedException();
		}

		void Account_Clicked(object sender, System.EventArgs e)
		{
			
			new MainPage().Detail.Navigation.PushAsync(new AccountPage());

		}

	}
}
