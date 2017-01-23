using System;
using System.Collections.Generic;
using ParkPass.Views;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class LoginPage : ContentPage
	{
		private  void Login_Clicked(object sender, System.EventArgs e)
		{

	//		await Navigation.PushAsync(new MainPage(), true);
		
		}



		public LoginPage()
		{
			InitializeComponent();
		}


		//private async void AuthenticateUser(string access)
		//{
		////	Acr.UserDialogs.UserDialogs.Instance.ShowLoading("Logging In");

		//	OperationResult result;
		//	if (string.IsNullOrWhiteSpace(access))
		//	{
		//		result = await AccountService.AuthenticateUser(emailEntry.Text, passwordEntry.Text);

		//	}
		//	else
		//	{
		//		if (string.IsNullOrWhiteSpace(UserContext.Profile.Provider))
		//		{
		//			result = await AccountService.AuthenticateUser(UserContext.Profile.UserName, access);
		//		}
		//		else
		//		{
		//			result = await AccountService.AuthenticateUserWithExternalToken(access);
		//		}
		//	}

		////	Acr.UserDialogs.UserDialogs.Instance.HideLoading();
		//	if (!result.Succeeded)
		//	{
		//		await DisplayAlert("Login Failed", "error", "Cancel");
		//	}
		//	else
		//	{
		//		Navigation.PushModalAsync(new MainPage(), true);
		//	}
		//}

		/// <summary>
		/// Validates the login input and starts the login process.
		/// </summary>
		/// <param name="sender">Not used.</param>
		/// <param name="e">Not used.</param>
		//private void OnLoginButtonClicked(object sender, EventArgs e)
		//{
		//	if (!string.IsNullOrWhiteSpace(emailEntry.Text) && !string.IsNullOrWhiteSpace(passwordEntry.Text))
		//	{
		//		AuthenticateUser(string.Empty);
		//	}
		//	else
		//	{
		//		DisplayAlert("Login Failed", "Email and Password Required.", "Cancel");
		//	}
		//}


	}
}
