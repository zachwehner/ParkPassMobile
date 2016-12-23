using System;
using System.Collections.Generic;
using ParkPass;
using Xamarin.Forms;
using ParkPass.Models;
namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public string ParkNameValue2;
		public ParkPage()
		{
			InitializeComponent();
		


			ParkListView.ItemsSource = new List<ParkListItem>
			{
				new ParkListItem {
					Name = "YellowStone",
					City = "Wyoming",
					State = "Wyoming",
					ImagePath = "Park_Placeholder.png",
					Description = "You can find lots of Bison and Black Bears"
				},
				new ParkListItem {
					Name = "Yosemite",
					City = "Wyoming",
					State = "California",
					ImagePath = "Yosemite_Placeholder.png",
					Description = "Lots of large trees and high mountains"
				},
				new ParkListItem {
					Name = "GrandTeton",
					City = "Cold City",
					State = "Wyoming",
					ImagePath = "GrandTeton.jpg",
					Description = "The grandest of Tetons. Look for large mountains"
				}
			};
		}

		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var park = (ParkListItem) ParkListView.SelectedItem;
			Application.Current.Properties["currentPark"] = park;
			MessagingCenter.Send<ParkPage, ParkListItem>(this, "ParkPassName", park);

			await Navigation.PopModalAsync();
	
		}


		void HandleAction()
		{
			throw new NotImplementedException();
		}
	}
}
