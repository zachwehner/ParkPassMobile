using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParkPass.Views;
//using Stripe;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class CheckoutPage : ContentPage
	{
		ParkPassCell selectedPass;

		public CheckoutPage()
		{
			 

			//if (pass != null)
			//{
			//	selectedPass = pass;
			//}
			//else {
			//	Invalid_PassSelected();
			//	Navigation.PopModalAsync();
			//}
			InitializeComponent();
		}

		async void Invalid_PassSelected()
		{

			await DisplayAlert("Error", "Invalid Pass Selected", "Go Back");

			await Navigation.PopModalAsync();

		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{

			//CALL WEBSERVICE TO PURCHASE AND RETRIEVE PASSCODE AND RETURN MESSAGE
			//await Save();
			var barcodePage = new BarcodePage(selectedPass);
			Navigation.PopModalAsync();
			Navigation.PushModalAsync(barcodePage);

		}

	
	
	}
}
