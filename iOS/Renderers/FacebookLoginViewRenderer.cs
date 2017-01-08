using System;
using Facebook.LoginKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass.Views;
using ParkPass.iOS;
using Parkpass.iOS;

[assembly: ExportRenderer(typeof(FacebookLoginView), typeof(FacebookLoginViewRenderer))]
namespace ParkPass.iOS
{

	public class FacebookLoginViewRenderer : ViewRenderer<FacebookLoginView, LoginButton>
	{
		/// <summary>
		/// Method used to instantiate the native view.
		/// </summary>
		protected override void OnElementChanged(ElementChangedEventArgs<FacebookLoginView> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || this.Element == null)
				return;

			if (Control == null)
			{
				LoginButton loginButton = new LoginButton();
				loginButton.LoginBehavior = LoginBehavior.Native;
				loginButton.ReadPermissions = ParkPass.Constants.FacebookReadPermissions;

				ExternalLoginService externalLoginService = new ExternalLoginService();
				//Login button callback.
				loginButton.Completed += (sender, evt) =>
				{
					if (evt.Error != null)
					{
						return;
					}

					if (evt.Result.IsCancelled)
					{
						return;
					}

					externalLoginService.ProcessFacebookLogin(evt.Result.Token.TokenString);
				};

				SetNativeControl(loginButton);
			}

		}
	}
}
