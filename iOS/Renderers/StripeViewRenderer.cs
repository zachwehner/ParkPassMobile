using System;
using Xamarin.Forms;
using ParkPass.Views;
using Stripe;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using System.Threading.Tasks;

using PassKit;

[assembly: ExportRenderer(typeof(ParkPass.Views.StripeView), typeof(ParkPass.iOS.StripeViewRenderer))]
namespace ParkPass.iOS
{
	public class StripeViewRenderer : ViewRenderer<ParkPass.Views.StripeView, Stripe.StripeView>
	{



		protected override void OnElementChanged(ElementChangedEventArgs<ParkPass.Views.StripeView> e)
		{
			base.OnElementChanged(e);

var native = new Stripe.StripeView();

//			// set up whatever you need to between the native and XF views
//			// hint: the Element property of this class will be the XF view

		Stripe.StripeView stripeView = new Stripe.StripeView();
			stripeView.Frame = new CGRect(10, 100, stripeView.Frame.Width, stripeView.Frame.Height);
			SetNativeControl(stripeView);

//			//	View.AddSubview(stripeView);


		//	SetNativeControl(native);


		}

		//async Task HandlePaymentAuthorization(PKPayment payment, PKPaymentAuthorizationHandler completion)
		//{

		//	try
		//	{
		//		var token = await StripeClient.CreateToken(payment);
		//	}
		//	catch (Exception ex)
		//	{
		//	}
		//}

	}




}