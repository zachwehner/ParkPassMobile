using System;
using System.Collections.Generic;
using System.IO;
using ParkPass.Models;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using ZXing.Mobile;

using ParkPass.Services;

namespace ParkPass
{
	public partial class BarcodePage : ContentPage
	{

		ZXingBarcodeImageView barcode;


		public BarcodePage()
		{
			InitializeComponent();

			//barcode = new ZXingBarcodeImageView
			//{
			//	HorizontalOptions = LayoutOptions.FillAndExpand,
			//	VerticalOptions = LayoutOptions.FillAndExpand,

			//};
			//barcode.Margin = 20;
			//barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;

			//barcode.BarcodeOptions.Width = 100;
			//barcode.BarcodeOptions.Height = 100;
			//barcode.BarcodeOptions.Margin = 10;
			//barcode.BarcodeValue = "ZXing.Net.Mobile";
			Image barcode = new Image
			{
				Source = "QRcode_Placeholder.png"
			};
			var purchasedLabel = new Label
			{
				Text = "Purchased",
				FontSize = 24,
				TextColor = Color.FromHex("979797")
			};
			var passLabel = new Label
			{
				Text = "Adult Pass"
			};
			var passDescriptionLabel = new Label
			{
				Text = "This pass is valid until 09/17"
			};
			var walletButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex("FFFFFF"),


				Text = "Save To Wallet"
			};
			walletButton.Clicked += Wallet_Clicked;
			var emailButton = new Button
			{
				BackgroundColor = Color.FromHex("7ED321"),
				TextColor = Color.FromHex("FFFFFF"),

				Text = "Send To Email"
			};
			emailButton.Clicked += Email_Clicked;
			Content = new Frame
			{
				Content =
				new StackLayout
				{
					Spacing = 10,
					Children = { purchasedLabel, passDescriptionLabel, barcode, walletButton, emailButton }


				}
			};
			                                      
		}
		async void Wallet_Clicked(object sender, System.EventArgs e)
		{

			await DisplayAlert("Alert", "Passes have been saved to Wallet!", "OK");

			await Navigation.PopModalAsync();


		}
		async void Email_Clicked(object sender, System.EventArgs e)
		{

			await DisplayAlert("Confirmation", "Passes Sent To Email", "OK");

		
			await Navigation.PopModalAsync();

		}
	}
}
