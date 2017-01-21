using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.CoreKit;
using Foundation;
using Google.Core;
using Google.SignIn;
using UIKit;


namespace ParkPass.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			global::ZXing.Net.Mobile.Forms.iOS.Platform.Init();


			//Stripe.StripeClient.DefaultPublishableKey = "sk_test_yfagzMr4NXypHZ66vJoe6Q34";
			InitGoogleSignIn();
		//	InitFacebookSignIn();
			LoadApplication(new App());
			App.Init(new iOSDisplaySettings());
			return base.FinishedLaunching(app, options);
		}

		public void InitGoogleSignIn()
		{
			NSError configureError;
			Context.SharedInstance.Configure(out configureError);
			if (configureError != null)
			{
				SignIn.SharedInstance.ClientID = ParkPass.Constants.GoogleClientId;
			}
			SignIn.SharedInstance.ClientID = ParkPass.Constants.GoogleClientId;
			SignIn.SharedInstance.Scopes = new ParkPass.Constants().GoogleScopes;
			SignIn.SharedInstance.SignOutUser();
		}

		/// <summary>
		/// Initializes the facebook sign in sdk.
		/// </summary>
		//public void InitFacebookSignIn()
		//{
		//	Settings.AppID = Configuration.FacebookAppID;
		//	Settings.DisplayName = Configuration.FacebookDisplayName;
		//}
	}
}
