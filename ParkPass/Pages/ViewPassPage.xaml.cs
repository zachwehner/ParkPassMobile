using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ParkPass
{
	public partial class ViewPassPage : ContentPage
	{
		ZXingBarcodeImageView barcode;

		public ViewPassPage(string passName, string passDescription, string passStatus, string passCode, string passPurchasedDate)
		{
			InitializeComponent();

			barcode = new ZXingBarcodeImageView
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,

			};
			barcode.Margin = 0;
			barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;

			barcode.BarcodeOptions.Width = 400;
			barcode.BarcodeOptions.Height = 300;
			barcode.BarcodeOptions.Margin = 0;
			barcode.BarcodeValue = "ZXing.Net.Mobile";
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
				Text = passName
			};
			var passType = new Label
			{
				Text = "Type Of Pass",
				FontSize = 10,
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
				Text = passDescription
			};






			var disclaimer1 = "- Pass is valid for ENTRANCE FEES only";
			var disclaimer2 = "- Admits the pass holder and occupants of a single, private non-commercial vehicle OR pass holder and three persons " +
				"(16 and older where individual ENTRANCE FEES are charged.";
			var disclaimer3 = "- May be upgraded to park specific annual pass at this park or Inter-agency Annual Pass at any National Park.";
			var disclaimer4 = " -Non Refundable";



			Content =
				new StackLayout
				{
					
					Opacity = 10,
					Spacing = 10,
					Children = {

					new Frame
					{
				Padding = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				OutlineColor = Color.Black,
				HasShadow = true,
						Content =
					new StackLayout{
						Padding = 20,
						 Spacing = 0,
						   Orientation = StackOrientation.Horizontal,
						   Children =
									{
							barcode,

							new StackLayout{
								Spacing = 5,
						   		Orientation = StackOrientation.Vertical,
								Children ={

									purchasedLabel,
									passLabel,
									passNameLabel,
									passType,
									passDescriptionLabel,
									passPurchasedLabel,
									passPurchasedDateLabel
									}
								}

								}
							}

					},
					new Frame {
						Padding = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				OutlineColor = Color.Black,
				HasShadow = true,
						Content=
					new StackLayout{
						   Spacing = 0,
						   Orientation = StackOrientation.Vertical,
						   Children =
									{

										new Label
										{
											Text = disclaimer1,
										},
										new Label
										{
											Text = disclaimer2,
											HorizontalOptions = LayoutOptions.CenterAndExpand
										},
										new Label
										{
											Text = disclaimer3,
										},
									}


					}
					}



				}
				};
		}

	}
}
