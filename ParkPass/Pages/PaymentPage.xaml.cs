using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class PaymentPage : ContentPage
	{
		public PaymentPage()
		{
			InitializeComponent();
		}

		public async void Card_Clicked(object sender, System.EventArgs e)
		{
			

			CardPage cardPage = new CardPage();
		
			await Navigation.PushPopupAsync(cardPage);
		}

		public async void BillingAddress_Clicked(object sender, System.EventArgs e)
		{
			

			BillingAddressPage billingAddressPage = new BillingAddressPage();

			await Navigation.PushPopupAsync(billingAddressPage);
		}
		public async void Method_Clicked(object sender, System.EventArgs e)
		{
			

			BillingAddressPage billingAddressPage = new BillingAddressPage();

			await Navigation.PushPopupAsync(billingAddressPage);
		}
	}
}
