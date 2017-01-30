using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Acr.UserDialogs;

namespace ParkPass
{
	public partial class LogPage : ContentPage
	{
		
		LoginService loginService = new LoginService();
		public static string clientId = "e31777d1-cc82-4397-afa5-0da1d4bfc0fc";
		public static string authority = "https://login.windows.net/common";
		public static string returnUri = "urn:ietf:wg:oauth:2.0:oob";
		private const string graphResourceUri = "https://graph.windows.net";
		private AuthenticationResult authResult = null;

		private async void Login_Clicked(object sender, System.EventArgs e)
		{
			


			var errorMsg = string.Empty;
			if (string.IsNullOrWhiteSpace(emailEntry.Text)
			    || string.IsNullOrWhiteSpace(passwordEntry.Text))
			{
				errorMsg = "All fields are required.";
			}


			if (string.IsNullOrWhiteSpace(errorMsg))
			{
				UserDialogs.Instance.ShowLoading("Loading", MaskType.Black);
				RequestResponse loginRequestResponse = await loginService.Login(emailEntry.Text, passwordEntry.Text);
				UserDialogs.Instance.HideLoading();
				if (loginRequestResponse.Successful == false)
				{
					if (loginRequestResponse.badRequestReponse.ModelState != null)
					{
						foreach (KeyValuePair<string, string[]> error in loginRequestResponse.badRequestReponse.ModelState)
							DisplayAlert("Login Error", error.Value[0], "OK");
					}
					else
					{
						DisplayAlert("Error", "Error Logging In", "OK");
					}
				}
				else
				{
					await Navigation.PushAsync(new TempNavPage(), true);
				}
			}
			else
			{
				DisplayAlert("Empty Fields", errorMsg, "cancel");
			}

		}


		async void NewAccount_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AccountPage(), true);
		}

		async void Facebook_Clicked(object sender, System.EventArgs e)
		{
			var x = await loginService.GetExternalLoginProviders();
			await Navigation.PushAsync(new AccountPage(), true);
		}

		public LogPage(string email)
		{
			
			InitializeComponent();

			emailEntry.Text = email;
			NavigationPage.SetHasNavigationBar(this, false); 
		}
	}




}
