using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
namespace ParkPass
{
	public partial class LogPage : ContentPage
	{
		public static string clientId = "e31777d1-cc82-4397-afa5-0da1d4bfc0fc";
		public static string authority = "https://login.windows.net/common";
		public static string returnUri = "urn:ietf:wg:oauth:2.0:oob";
		private const string graphResourceUri = "https://graph.windows.net";
		private AuthenticationResult authResult = null;

		private async void Login_Clicked(object sender, System.EventArgs e)
		{

			 var auth = DependencyService.Get<IAuthenticator>();
			 var data = await auth.Authenticate(authority, graphResourceUri, clientId, returnUri);
			 var userName = data.UserInfo.GivenName + " " + data.UserInfo.FamilyName;
			 await DisplayAlert("Token", userName, "Ok", "Cancel");
		
		}


		async void NewAccount_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new AccountPage(), true);
		}

		public LogPage()
		{
			
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false); 
		}
	}




}
