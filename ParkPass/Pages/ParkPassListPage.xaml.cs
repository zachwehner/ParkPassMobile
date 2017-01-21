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

			myPassesListView.RowHeight = 568/2 ;

			myPassesListView.ItemsSource = new List<ParkPassCell>
			{
				new ParkPassCell{
					ParkName= "",
					Name="ANNUAL PASS",
					Category = "Daily Pass",
					Status = "Unused",
					ImageFilename ="Park_Placeholder.png",
					PassPrice = "100.00",
					PurchasedDate = "01/10/2016"
				},


					new ParkPassCell{
					ParkName= "GrandTetons",
					Name="DAY PASS",
					Category = "Daily Pass",
					Status = "Used",
					ImageFilename ="Yosemite_Placeholder.png",
					PassPrice = "15.00",
					PurchasedDate = "01/10/2015"
					},
				new ParkPassCell{
					ParkName= "Glacier",
					Name="Child",
					Category = "Daily Pass",
					Status = "Used",
					ImageFilename ="Park_Placeholder.png",
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
			var x = App.DisplaySettings.GetHeight();
			passName = pass.Name;
			passDescription = pass.Category;
			passStatus = pass.Status;
			passPurchasedDate = pass.PurchasedDate;
			passCode = "0101011";
			//MessagingCenter.Send<ParkPage, ParkListItem>(this, "ParkPassName", park);
			await Navigation.PushAsync(new ViewPassPage());
		//	await Navigation.PushAsync(new ViewPassPage(passName, passDescription, passStatus, passCode, passPurchasedDate));
		}
	}
}
