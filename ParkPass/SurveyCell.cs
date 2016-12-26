using System;
using Xamarin.Forms;

namespace ParkPass
{
	public class SurveyCell : ViewCell
	{

		public static readonly BindableProperty SurveyNameProperty =
		  BindableProperty.Create("SurveyName", typeof(string), typeof(SurveyCell), "");
		
		public string SurveyName
		{
			get { return (string)GetValue(SurveyNameProperty); }
			set { SetValue(SurveyNameProperty, value); }
		}

		public static readonly BindableProperty DescriptionProperty =
		  BindableProperty.Create("Description", typeof(string), typeof(SurveyCell), "");

		public string Description
		{
			get { return (string)GetValue(DescriptionProperty); }
			set { SetValue(DescriptionProperty, value); }
		}



		public static readonly BindableProperty ImageFilenameProperty =
		  BindableProperty.Create("ImageFilename", typeof(string), typeof(SurveyCell), "");

		public string ImageFilename
		{
			get { return (string)GetValue(ImageFilenameProperty); }
			set { SetValue(ImageFilenameProperty, value); }
		}
		
	}
}

