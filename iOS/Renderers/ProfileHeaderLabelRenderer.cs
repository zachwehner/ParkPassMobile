using System;
using ParkPass.Views;
using ParkPass.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ProfileHeaderLabel), typeof(ProfileHeaderLabelRenderer))]
namespace ParkPass.iOS
{
	public class ProfileHeaderLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			if (Control == null)
			{
				SetNativeControl(new TagUiLabel());
			}

		
		
			this.Control.BackgroundColor = UIColor.FromRGB(59, 35, 19);
			this.Control.Layer.CornerRadius = 2;
			this.Control.Layer.BorderColor =  new CGColor(59, 35, 19);
			this.Control.Layer.MasksToBounds = true;
	
			this.Control.ClipsToBounds = true;
			base.OnElementChanged(e);
		}
	}
	public class TagUiLabel : UILabel
	{
		private UIEdgeInsets EdgeInsets { get; set; }

		public TagUiLabel()
		{
			EdgeInsets = new UIEdgeInsets(10, 10, 10, 0);
		}
		public override void DrawText(CoreGraphics.CGRect rect)
		{
			base.DrawText(EdgeInsets.InsetRect(rect));
		}
	}
}

