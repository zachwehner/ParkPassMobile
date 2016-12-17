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
			//this.ToolbarItems.Add(new ToolbarItem("Menu", "Hamburger_Menu.png", HandleAction, ToolbarItemOrder.Default, 0));
			//this.ToolbarItems.Add(new ToolbarItem(parkNameValue, null, ParkName_Clicked, ToolbarItemOrder.Default, 0));
			this.ToolbarItems.Add(new ToolbarItem("Purchase", "purchase.png", HandleAction, ToolbarItemOrder.Default, 0));

			InitializeComponent();

		}

		void HandleAction()
		{
			throw new NotImplementedException();
		}



	}
}
