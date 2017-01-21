//[assembly: ExportRenderer(typeof(TextEntry), typeof(TextEntryRenderer))]
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Google.SignIn;

using ParkPass;
using ParkPassOS.Renderers;
using ParkPass.Views;

[assembly: ExportRenderer(typeof(GoogleLoginView), typeof(GoogleLoginViewRenderer))]
namespace ParkPassOS.Renderers
{
	
		public class GoogleLoginViewRenderer : ViewRenderer<GoogleLoginView, SignInButton>
	{
		/// <summary>
		/// Method used to instantiate the native view.
		/// </summary>
		protected override void OnElementChanged(ElementChangedEventArgs<GoogleLoginView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				SignInButton signInButton = new SignInButton();
				signInButton.Style = ButtonStyle.Standard;
				signInButton.ColorScheme = ButtonColorScheme.Light;
				SetNativeControl(signInButton);
			}
		}
	}

	}


