using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkPassListPage : ContentPage
	{
		public ParkPassListPage()
		{
			InitializeComponent();
			myPassesListView.ItemsSource = new List<ParkPassCell>
			{
				new ParkPassCell{
					ParkName= "YellowStone",
					Name="Adult",
					Category = "Daily Pass",
					Status = "Unused",
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "100.00",
					PurchasedDate = "01/10/2016"
				},


					new ParkPassCell{
					ParkName= "GrandTetons",
					Name="Adult",
					Category = "Daily Pass",
					Status = "Used",
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "15.00",
					PurchasedDate = "01/10/2015"
					},
				new ParkPassCell{
					ParkName= "Glacier",
					Name="Child",
					Category = "Daily Pass",
					Status = "Used",
					ImageFilename ="QRcode_Placeholder.png",
					PassPrice = "76.00",
					PurchasedDate = "05/10/2015"
					}

			};
		}

		public async void Handle_Tapped(object sender, System.EventArgs e)
		{
			var pass = (ParkPassCell)myPassesListView.SelectedItem;

			string passName;
			string passDescription;
			string passStatus;
			string passCode;
			string passPurchasedDate;

			passName = pass.Name;
			passDescription = pass.Category;
			passStatus = pass.Status;
			passPurchasedDate = pass.PurchasedDate;
			passCode = "0101011";
			//MessagingCenter.Send<ParkPage, ParkListItem>(this, "ParkPassName", park);

			await Navigation.PushAsync(new ViewPassPage(passName, passDescription, passStatus, passCode, passPurchasedDate));
		}
	}
}
