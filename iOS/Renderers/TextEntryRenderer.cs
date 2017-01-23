using System;
using CoreAnimation;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
namespace ParkPass.iOS.Renderer
{
	public class TextEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.AttributedPlaceholder = new NSAttributedString(
						"Enter your credentials",
						font: UIFont.FromName("HoeflerText-Regular", 14.0f),
						foregroundColor: UIColor.Red,
						strokeWidth: 4
					);

				Control.BackgroundColor = UIColor.FromRGB(119, 171, 233);
				Control.Font = UIFont.FromName("HelveticaNeue-Thin", 20);
				//Control.SetValueForKeyPath(UIColor.White, new NSString("_placeholderLabel.textColor"));
				Control.Layer.SublayerTransform = CATransform3D.MakeTranslation(0, 0, 0);
				Control.AutocorrectionType = UITextAutocorrectionType.No;  // No Autocorrection
				Control.BorderStyle = UITextBorderStyle.Line;
			}
		}
	}

}
