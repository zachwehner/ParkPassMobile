﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
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

			Stripe.StripeClient.DefaultPublishableKey = "sk_test_yfagzMr4NXypHZ66vJoe6Q34";

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}


	}
}
