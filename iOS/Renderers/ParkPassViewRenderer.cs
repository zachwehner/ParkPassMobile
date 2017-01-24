using System;
using Facebook.LoginKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass.iOS;
using Parkpass.iOS;
using ParkPass.Views;
using UIKit;

[assembly: ExportRenderer(typeof(ParkPassView), typeof(ParkPassViewRenderer))]
namespace ParkPass.iOS
{
	public class ParkPassViewRenderer: ViewRenderer<ParkPassView, UIView>{
		protected override void OnElementChanged(ElementChangedEventArgs<ParkPassView> e)
		{
			base.OnElementChanged(e);

			//var parkPassView = new ParkPassView();
			//if (this.Control != null)

			//{

			//}
		}
	}
}


