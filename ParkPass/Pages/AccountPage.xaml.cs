using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class AccountPage : ContentPage
	{
		public AccountPage()
		{
			InitializeComponent();
			//NavigationPage.SetHasNavigationBar(this, false);

		}
		async void CreateAccount_Clicked(object sender, System.EventArgs e)
		{
			RegisterService reg = new RegisterService();

			var errorMsg = string.Empty;
			if (string.IsNullOrWhiteSpace(firstNameEntry.Text)
				|| string.IsNullOrWhiteSpace(lastNameEntry.Text)
				|| string.IsNullOrWhiteSpace(emailEntry.Text)
				|| string.IsNullOrWhiteSpace(passEntry.Text))
			{
				errorMsg = "All fields are required.";
			}
		

			if (string.IsNullOrWhiteSpace(errorMsg))
			{
				RequestResponse registrationRequestResponse = await reg.Register(emailEntry.Text, passEntry.Text, passEntry.Text);

				if (registrationRequestResponse.Successful == false)
				{
					if (registrationRequestResponse.badRequestReponse.ModelState != null)
					{
						foreach( KeyValuePair<string,string[]> error in registrationRequestResponse.badRequestReponse.ModelState)
							DisplayAlert("Registration Error", error.Value[0], "OK");
					}
					else
					{
						DisplayAlert("Error", "Error Creating Account", "OK");
					}
				}
				else
					await Navigation.PushAsync(new LogPage(emailEntry.Text), true);
			}
			else
			{
				DisplayAlert("Error Creating Account", errorMsg, "cancel");
			}


		}

	}
}
