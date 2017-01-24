using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ParkPass
{
	public partial class ViewPassPage : ContentPage
	{
		ZXingBarcodeImageView barcode;
		//public ViewPassPage(string passName, string passDescription, string passStatus, string passCode, string passPurchasedDate)
		public ViewPassPage(int displayHeight, int displayWidth)
		{
			InitializeComponent();



			string passName = "Annual Pass";
			string passDescription = "Test";
			string passStatus = "Unused";
			//string passCode
			string passPurchasedDate = "01/07/2017";
			barcode = new ZXingBarcodeImageView
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,

			};
			//barcode.Margin = displayWidth * .05;
			barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
			barcode.WidthRequest = displayWidth ;
			barcode.HeightRequest = displayWidth * .67;
			barcode.BarcodeOptions.Width = displayWidth ;
			barcode.BarcodeOptions.Height = displayWidth;
			//barcode.BarcodeOptions.Margin = 0;
			barcode.BarcodeValue = "I Generated this Park Pass Code This is Ticket # 1001010101 With Expiration date 10/19";
			var PassTypeLabel = new Label
			{
				Text = "ANNUAL PASS",
				FontFamily = "SanFranciscoText-Light",
				FontSize = 36,
				TextColor = Color.FromHex("979797")
			};
			var lblExpirationLabel = new Label
			{
				FontSize = 14,
				FontAttributes = FontAttributes.Bold,
				Text = "Expires",
					FontFamily = "SanFranciscoDisplay - Light",
			};
			var ExpirationLabel = new Label
			{
				FontSize = 14,
				Text = "01/07/2017",
					FontFamily = "SanFranciscoDisplay - Light",
			};
			var lblLastUsed = new Label
			{
				Text = "Last Used",
				FontAttributes = FontAttributes.Bold,
				FontSize = 14,
				FontFamily = "SanFranciscoDisplay - Light",

			};
			var LastUsed = new Label
			{
				Text = "01/08/2017",
				FontSize = 14,
				TextColor = Color.FromHex("555555"),
				FontFamily = "SanFranciscoDisplay - Light",

			};
			var lblParkName = new Label
			{
				Text = "Park",
				FontSize = 14,
				FontAttributes = FontAttributes.Bold,

				FontFamily = "SanFranciscoDisplay - Light",
			};

			var ParkName = new Label
			{
				Text = "Yellowstone",
				FontSize = 14,
				FontFamily = "SanFranciscoDisplay - Light",
			};
		


			Grid grid = new Grid();
			grid.RowDefinitions.Add(new RowDefinition());
			grid.RowDefinitions.Add(new RowDefinition());
			grid.RowDefinitions.Add(new RowDefinition());
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			grid.Children.Add(lblExpirationLabel, 0, 0);
			grid.Children.Add(ExpirationLabel, 1, 0);
			grid.Children.Add(lblLastUsed, 0, 1);
			grid.Children.Add(LastUsed, 1, 1);
			grid.Children.Add(lblParkName, 0, 2);
			grid.Children.Add(ParkName, 1, 2);
			Content =
				new StackLayout
				{

					Opacity = 10,
					Spacing = 10,
					Children = {

					new Frame
					{
						
				OutlineColor = Color.Gray,
				HasShadow = true,
						Content =
							barcode

					},
					PassTypeLabel,
					grid
						 //  Spacing = 0,
						 //  Orientation = StackOrientation.Vertical,
						 //  Children =
							//		{
							//passNameLabel,
							//	purchasedLabel,
							//		passLabel,
							//	passPurchasedLabel,
							//		passPurchasedDateLabel,
							//	passType,
							//		passDescriptionLabel,
							//		}


				




				}
				};
		}

	}
}
