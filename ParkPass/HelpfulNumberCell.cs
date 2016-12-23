using System;
using Xamarin.Forms;
namespace ParkPass
{
	public class HelpfulNumberCell : ViewCell
	{
		public static readonly BindableProperty HelpfulNumberNameProperty =
		  BindableProperty.Create("HelpfulNumberName", typeof(string), typeof(HelpfulNumberCell), "");

		public string HelpfulNumberName
		{
			get { return (string)GetValue(HelpfulNumberNameProperty); }
			set { SetValue(HelpfulNumberNameProperty, value); }
		}

		public static readonly BindableProperty DescriptionProperty =
		  BindableProperty.Create("Description", typeof(string), typeof(HelpfulNumberCell), "");

		public string Description
		{
			get { return (string)GetValue(DescriptionProperty); }
			set { SetValue(DescriptionProperty, value); }
		}

		public static readonly BindableProperty PhoneProperty =
		  BindableProperty.Create("Phone", typeof(string), typeof(HelpfulNumberCell), "");

		public string Phone
		{
			get { return (string)GetValue(PhoneProperty); }
			set { SetValue(PhoneProperty, value); }
		}


		public static readonly BindableProperty ImageFilenameProperty =
		  BindableProperty.Create("ImageFilename", typeof(string), typeof(ParkPassCell), "");

		public string ImageFilename
		{
			get { return (string)GetValue(ImageFilenameProperty); }
			set { SetValue(ImageFilenameProperty, value); }
		}
	}
}
