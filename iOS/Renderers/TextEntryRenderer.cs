using System;
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
				Control.AutocorrectionType = UITextAutocorrectionType.No;  // No Autocorrection
			}
		}
	}

}
