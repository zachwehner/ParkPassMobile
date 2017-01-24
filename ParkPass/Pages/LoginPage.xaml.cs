using System;
using System.Collections.Generic;
using ParkPass.Views;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class LoginPage : ContentPage
	{

		public static string clientId = "e31777d1-cc82-4397-afa5-0da1d4bfc0fc";
		public static string authority = "https://login.windows.net/common";
		public static string returnUri = "urn:ietf:wg:oauth:2.0:oob";
		private const string graphResourceUri = "https://graph.windows.net";
		private AuthenticationResult authResult = null;

		private  void Login_Clicked(object sender, System.EventArgs e)
		{

			 var auth = DependencyService.Get<IAuthenticator>();
			 var data = await auth.Authenticate(authority, graphResourceUri, clientId, returnUri);
			 var userName = data.UserInfo.GivenName + " " + data.UserInfo.FamilyName;
			 await DisplayAlert("Token", userName, "Ok", "Cancel");
		
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
