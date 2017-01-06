using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ParkPass.Models;
namespace ParkPass
{
	public partial class ParkPassPage : ContentPage
	{
		public ParkPassPage()
		{
			InitializeComponent();

			ParkPassListView.ItemsSource = new List<ParkPassCell>
			{
				new ParkPassCell {
					Name = "Adult",
					Category = "Daily Pass",
				
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "100.00",
				},
				new ParkPassCell {
					Name = "Child",
					Category = "Daily Pass",
				
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "100.00",
				
				},
				new ParkPassCell {
					Name = "Family",
					Category = "Season Pass",
			
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "100.00",

				}
			};
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{


			var park = (ParkPassCell) ParkPassListView.SelectedItem;
		

		
			var checkoutPage = new CheckoutPage(park);

			Navigation.PopModalAsync();
			await Navigation.PushModalAsync(checkoutPage);
		}


	}
}
