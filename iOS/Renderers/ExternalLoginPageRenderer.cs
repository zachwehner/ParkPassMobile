using System;
using System.Linq;
using Google.SignIn;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace ParkPass.iOS
{
	
		public class ExternalLoginPageRenderer : PageRenderer, ISignInUIDelegate, ISignInDelegate
		{
		//	private ExternalLoginService externalLoginService;

			public override void ViewDidLoad()
			{
				base.ViewDidLoad();
				View.GestureRecognizers.OfType<UITapGestureRecognizer>().First().CancelsTouchesInView = false; //fix mentioned by AdamKemp here for the button TouchUpInside event not firing: https://forums.xamarin.com/discussion/comment/171084/#Comment_171084
				SignIn.SharedInstance.UIDelegate = this;
				SignIn.SharedInstance.Delegate = this;
			//	externalLoginService = new ExternalLoginService();
			}

			/// <summary>
			/// Google iOS sign in SDK button callback.
			/// </summary>
			public void DidSignIn(SignIn signIn, GoogleUser gUser, Foundation.NSError error)
			{
				if (error != null)
				{
					return;
				}

				if (gUser == null)
				{
					return;
				}

			//	externalLoginService.ProcessGoogleLogin(gUser);
			}

	}
}
