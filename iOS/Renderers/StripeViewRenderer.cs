using System;
using Xamarin.Forms;
using ParkPass.Views;
using Stripe;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using System.Threading.Tasks;
using System.ComponentModel;
using PassKit;

[assembly: ExportRenderer(typeof(ParkPass.Views.StripeView), typeof(ParkPass.iOS.StripeViewRenderer))]
namespace ParkPass.iOS
{
	public class StripeViewRenderer : ViewRenderer<ParkPass.Views.StripeView, Stripe.StripeView>
	{
		Stripe.StripeView _view;

		public StripeViewRenderer()
		{
		}


		protected override void OnElementChanged(ElementChangedEventArgs<ParkPass.Views.StripeView> e)
		{
			
			   base.OnElementChanged(e);
			// set up whatever you need to between the native and XF views
			// hint: the Element property of this class will be the XF view
			if (_view == null)
			{   // perform initial setup
				// do whatever you want to the UITextField here!
				_view = new Stripe.StripeView();
				SetNativeControl(_view);
			}
			if (Element != null)
			{
				var stripeView1 = (Views.StripeView)Element;
				_view.LayoutIfNeeded();
			}


//			// set up whatever you need to between the native and XF views
//			// hint: the Element property of this class will be the XF view

		

		//	SetNativeControl(native);


		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == "GUID")
			{
				Element.Number = Control.Card.Number;
				Element.ExpiryYear = Control.Card.ExpiryYear;
				Element.ExpiryMonth = Control.Card.ExpiryMonth;
				Element.CVC = Control.Card.CVC;
			}
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
//base.OnElementChanged(e);
//var native = new Stripe.StripeView();
//Stripe.StripeView stripeView = new Stripe.StripeView();
//stripeView.Frame = new CGRect(10, 100, stripeView.Frame.Width, stripeView.Frame.Height);
//			SetNativeControl(stripeView);

////			//	View.AddSubview(stripeView);
