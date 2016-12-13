using System;
using System.Collections.Generic;
using ParkPass;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public ParkPage()
		{
			InitializeComponent();


			ParkListView.ItemsSource = new List<ParkListItem>
			{
				new ParkListItem {
					Name = "YellowStone",
					City = "Wyoming",
					State = "Wyoming" },
				new ParkListItem {
					Name = "Grand Tetons",
					City = "Wyoming",
					State = "Wyoming"
				},
				new ParkListItem {
					Name = "Glacier",
					City = "Cold City",
					State = "Alaska"
				}
			};
		}

		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var park = (ParkListItem) ParkListView.SelectedItem;

			var x = park.Name;
			var y = new MenuPage();
		//	y.BindingContext = park as ParkNameValue;
			await Navigation.PopModalAsync();
	
		}


	}
}
