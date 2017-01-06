// -----------------------------------------------------------------------
// <copyright file="ExternalLoginService.cs" company="Automated Transportation Network">
// Copyright (C) Automated Transportation Network All Rights Reserved.
// </copyright>
// -----------------------------------------------------------------------

//using ParkPass.Models.Admin.UserManagement;
using Facebook.CoreKit;
using Facebook.LoginKit;
using Foundation;
using Google.SignIn;
using System.Text.RegularExpressions;
using UIKit;
using Xamarin.Forms;
using ParkPass;

namespace Parkpass.iOS
{
	/// <summary>
	/// Allows external account sign in interaction using the native Facebook and Google SDKs.
	/// </summary>
	public class ExternalLoginService
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalLoginService"/> class.
		/// </summary>
		public ExternalLoginService()
		{
			//// Subscribes to the logout message.
			//MessagingCenter.Subscribe<object>(this, MessageEventNames.ExternalLogout, (sender) =>
			//{
			//	ExternalLogout();
			//});
		}

		/// <summary>
		/// Checks if the facebook login request was successful.
		/// If successful it requests first name, last name, and email for the user from facebook.
		/// If the facebook account email is not provided then request an email from the user.
		/// Notifies "ExternalLogin" subscribers of the new facebook user to start server authentication.
		/// </summary>
		/// <param name="args">The arguments received from the completed callback on the facebook button.</param>
		public void ProcessFacebookLogin(string tokenString)
		{
			GraphRequest request = new GraphRequest("/me?fields=email,first_name,last_name", null, tokenString, null, "GET");
			var requestConnection = new GraphRequestConnection();
			requestConnection.AddRequest(request, (connection, result, errorHandler) =>
			{
				ProcessFacebookGraphResponse(result as NSDictionary, tokenString);
			});
			requestConnection.Start();
		}

		/// <summary>
		/// Gets the profile information of the user from facebook so that a an account can be created.
		/// </summary>
		/// <param name="result">The result containing the data.</param>
		/// <param name="tokenString">The tokenstring.</param>
		private void ProcessFacebookGraphResponse(NSDictionary result, string tokenString)
		{
			if (result == null)
			{
				UIAlertView alert = new UIAlertView("Error", "An error ocurred connecting to facebook.", null, "cancel");
				return;
			}

			//Parses the result dictionary for the information.
			var userInfo = result as NSDictionary;
			var firstName = userInfo["first_name"].ToString();
			var lastName = userInfo["last_name"].ToString();
			var email = userInfo.ObjectForKey(NSObject.FromObject("email"));
			////UserModel user = new UserModel()
			////{
			////	Provider = Configuration.Facebook,
			////	LastName = lastName,
			////	FirstName = firstName
			////};

			//if (email == null)
			//{
			//	RequestEmailDialog(user, tokenString);
			//}
			//else
			//{
			//	user.Email = email.ToString();
			//	user.UserName = user.Email;
			//	//UserContext.Profile = user;
			//	MessagingCenter.Send<object, string>(this, MessageEventNames.ExternalLogin, tokenString);
			//}
		}

		/// <summary>
		/// If the user's facebook account does not return an email (don't have one or they did not give permission)
		/// request an email from them. If they do not provide one log them out of facebook and do nothing.
		/// If they do provide an email notify the LoginPage that external login was successful.
		/// </summary>
		/// <param name="user">Ther user.</param>
		/// <param name="tokenString">The facebook token string.</param>
		private void RequestEmailDialog(UserModel user, string tokenString)
		{
			UIAlertView alert = new UIAlertView("Email Required", "Your Facebook account does not have an email associated to it. Park Pass Preferred requires one to send receipts.", null, "cancel", "ok");
			alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;

			// Event for enabling the okay button when the input validates.
			alert.ShouldEnableFirstOtherButton = (UIAlertView view) =>
			{
				var text = view.GetTextField(0).Text;
				Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
				return regex.Match(text).Success;
			};

			UITextField alertText = alert.GetTextField(0);
			alertText.KeyboardType = UIKeyboardType.EmailAddress;
			alertText.Placeholder = "Email";
			alert.Clicked += (sender, e) =>
			{
				//Event for when the okay button is pressed.
				if (e.ButtonIndex == 1)
				{
					user.Email = alertText.Text;
					user.UserName = user.Email;
					//UserContext.Profile = user;
				//	MessagingCenter.Send<object, string>(this, MessageEventNames.ExternalLogin, tokenString);
				}
			};

			alert.Dismissed += (sender, e) =>
			{
				ExternalLogout();
			};

			alert.Canceled += (sender, e) =>
			{
				ExternalLogout();
			};

			alert.Show();
		}

		/// <summary>
		/// Creates a user object from the googleUser object then notifies "Login" subscribers with the new User. 
		/// </summary>
		/// <param name="gUser">The google user received from the google sign in button callback.</param>
		public void ProcessGoogleLogin(GoogleUser gUser)
		{
			//UserContext.Profile = new UserModel()
			//{
			//	Email = gUser.Profile.Email,
			//	UserName = gUser.Profile.Email,
			//	FirstName = gUser.Profile.GivenName,
			//	LastName = gUser.Profile.FamilyName,
			//	Provider = Configuration.Google,
			//};
			//MessagingCenter.Send<object, string>(this, MessageEventNames.ExternalLogin, gUser.Authentication.IdToken);
		}

		/// <summary>
		/// Logs the local account out of google and facebook.
		/// </summary>
		public void ExternalLogout()
		{
			//Google sign out.
			SignIn.SharedInstance.SignOutUser();

			//Facebook sign out.
			new LoginManager().LogOut();
		}
	}
}
