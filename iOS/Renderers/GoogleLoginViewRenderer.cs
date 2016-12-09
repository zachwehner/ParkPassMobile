//[assembly: ExportRenderer(typeof(TextEntry), typeof(TextEntryRenderer))]
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ParkPassOS.Renderers
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


