using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage()
		{
			InitializeComponent();
		}

		public async void Purchase_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new MenuPage());
	
		}
		public async void ParkName_Clicked(object sender, System.EventArgs e)
		{
			var parkPage = new ParkPage();

			await Navigation.PushModalAsync(parkPage);
		
		}

	}
}
