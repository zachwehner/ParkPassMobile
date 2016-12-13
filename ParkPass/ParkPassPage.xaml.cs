using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkPassPage : ContentPage
	{
		public ParkPassPage()
		{
			InitializeComponent();

			ParkPassListView.ItemsSource = new List<ParkPassListItem>
			{
				new ParkPassListItem {
					Name = "Adult",
					Price = "100",
					Description = "This is an Adult Pass" },
				new ParkPassListItem {
					Name = "Child",
					Price = "56",
					Description = "This is a Child Pass"
				},
				new ParkPassListItem {
					Name = "Season",
					Price = "77",
					Description = "This is a season pass"
				}
			};
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var checkoutPage = new CheckoutPage();

			await Navigation.PushModalAsync(checkoutPage);
		}
	}
}
