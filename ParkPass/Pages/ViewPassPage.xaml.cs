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
			var purchasedLabel = new Label
			{
				Text = "Purchased",
				FontSize = 24,
				TextColor = Color.FromHex("979797")
			};
			var passLabel = new Label
			{
				FontSize = 10,
				Text = "Pass Type"
			};
			var passNameLabel = new Label
			{
				Text = passName,
				FontSize = 36,
				TextColor = Color.FromHex("555555"),
				FontFamily = "SanFranciscoDisplay - Light",

			};
			var passType = new Label
			{
				Text = passName,
				FontSize = 36,
				TextColor = Color.FromHex("555555"),
			};

			var passPurchasedLabel = new Label
			{
				Text = "Purchased Date",
				FontSize = 10,
			};
			var passPurchasedDateLabel = new Label
			{
				Text = passPurchasedDate,

			};
			var passDescriptionLabel = new Label
			{
	
					Text = passDescription,
				FontSize = 36,
				TextColor = Color.FromHex("555555"),
				FontFamily = "SanFranciscoDisplay - Light",
			};

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

					new StackLayout{
						   Spacing = 0,
						   Orientation = StackOrientation.Vertical,
						   Children =
									{
							passNameLabel,
								purchasedLabel,
									passLabel,
								passPurchasedLabel,
									passPurchasedDateLabel,
								passType,
									passDescriptionLabel,
									}


				
					}



				}
				};
		}

	}
}
