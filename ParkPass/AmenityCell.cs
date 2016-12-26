using System;
using Xamarin.Forms;

namespace ParkPass
{
	public class AmenityCell : ViewCell
	{
		public static readonly BindableProperty AmenityNameProperty =
		  BindableProperty.Create("AmenityName", typeof(string), typeof(AmenityCell), "");

		public string AmenityName
		{
			get { return (string)GetValue(AmenityNameProperty); }
			set { SetValue(AmenityNameProperty, value); }
		}

		public static readonly BindableProperty DescriptionProperty =
		  BindableProperty.Create("Description", typeof(string), typeof(AmenityCell), "");

		public string Description
		{
			get { return (string)GetValue(DescriptionProperty); }
			set { SetValue(DescriptionProperty, value); }
		}


		public static readonly BindableProperty ImageFilenameProperty =
		  BindableProperty.Create("ImageFilename", typeof(string), typeof(AmenityCell), "");

		public string ImageFilename
		{
			get { return (string)GetValue(ImageFilenameProperty); }
			set { SetValue(ImageFilenameProperty, value); }
		}
	}
}
