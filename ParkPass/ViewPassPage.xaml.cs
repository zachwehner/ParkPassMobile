using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ParkPass
{
	public partial class ViewPassPage : ContentPage
	{
		ZXingBarcodeImageView barcode;

		public ViewPassPage(string passName, string passDescription, string passStatus, string passCode)
		{
			InitializeComponent();

			barcode = new ZXingBarcodeImageView
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,

			};
			barcode.Margin = 10;
			barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;

			barcode.BarcodeOptions.Width = 300;
			barcode.BarcodeOptions.Height = 300;
			barcode.BarcodeOptions.Margin = 10;
			barcode.BarcodeValue = "ZXing.Net.Mobile";
			var purchasedLabel = new Label
			{
				Text = "Purchased",
				FontSize = 24,
				TextColor = Color.FromHex("979797")
			};
			var passLabel = new Label
			{
				Text = passName
			};
			var passDescriptionLabel = new Label
			{
				Text = passDescription
			};

			Content = new StackLayout
			{
				Spacing = 10,
				Children = { purchasedLabel, passDescriptionLabel, barcode }


			};

		}
	}
}
