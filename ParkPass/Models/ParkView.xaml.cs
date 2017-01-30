using System;
using System.Collections.Generic;
using XLabs.Forms.Controls;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkView : ContentPage
	{
		public ParkView()
		{
			InitializeComponent();
			SetPassesContent();
		}
		void Passes_Clicked(object sender, System.EventArgs e)
		{
			SetPassesContent();
		}
		void ParkInfo_Clicked(object sender, System.EventArgs e)
		{
			btnAlerts.BackgroundColor = Color.FromHex(Constants.brownLabelColor);
			btnPasses.BackgroundColor = Color.FromHex(Constants.brownLabelColor);
			btnInfo.BackgroundColor = Color.FromHex(Constants.orangeLabelColor);


			Label lblAbout = new ExtendedLabel
			{
				IsUnderline= true,
				Text = "ABOUT",
				FontSize = 20,
				TextColor = Color.FromHex(Constants.brownLabelColor)
			};

			Label AboutText = new Label
			{
				Text = "Yosemite National Park includes nearly 1,200 square miles of mountainous scenery, including high cliffs, deep valleys, tall waterfalls, ancient giant sequoias, and a large wilderness. Millions of people visit Yosemite each year to experience its beauty and its many opportunities for enjoyment.",
				FontSize = 14,
				TextColor = Color.FromHex(Constants.brownLabelColor)
			};
			Label lblDirection = new ExtendedLabel
			{
				IsUnderline = true,
				Text = "Direction",
				FontSize = 20,
				TextColor = Color.FromHex(Constants.brownLabelColor)
			};
			Label DirectionText = new Label
			{
				Text = "You can drive to Yosemite all year and enter via Highways 41, 140, and 120 from the west. Tioga Pass Entrance (via Highway 120 from the east) is closed from around November through late May or June. Hetch Hetchy is open all year but may close intermittently due to snow. Please note that GPS units do not always provide accurate directions to or within Yosemite.",
				FontSize = 14,
				TextColor = Color.FromHex(Constants.brownLabelColor)
			};
			ParkContentView.Content =
		new StackLayout
		{
			Spacing = 10,
			Children = { lblAbout, AboutText, lblDirection, DirectionText }


		};



		}

		void Alerts_Clicked(object sender, System.EventArgs e)
		{

			btnAlerts.BackgroundColor = Color.FromHex(Constants.orangeLabelColor);
			btnPasses.BackgroundColor = Color.FromHex(Constants.brownLabelColor);
			btnInfo.BackgroundColor = Color.FromHex(Constants.brownLabelColor);

			Label lblAbout = new Label
			{
				Text = "Alerts"
			};

			ParkContentView.Content = lblAbout;
		}


		void SetPassesContent()
		{
			myPassesListView.RowHeight = 200;
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

			btnAlerts.BackgroundColor = Color.FromHex(Constants.brownLabelColor);
			btnPasses.BackgroundColor = Color.FromHex(Constants.orangeLabelColor);
			btnInfo.BackgroundColor = Color.FromHex(Constants.brownLabelColor);
			ParkContentView.Content = myPassesListView;


		}


	}
}
