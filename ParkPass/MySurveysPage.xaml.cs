using System;
using System.Collections.Generic;
using ParkPass.Models;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class MySurveysPage : ContentPage
	{
		public MySurveysPage()
		{
			InitializeComponent();

			MySurveysListView.ItemsSource = new List<MySurveysListItem>
			{
				new MySurveysListItem {
					SurveyName = "Yellowstone Survey",
					SurveyDate = "02/10/2015"
					},
				new MySurveysListItem {
					SurveyName = "Glacier Survey",
					SurveyDate = "02/10/2015"
				},
				new MySurveysListItem {
					SurveyName = "Tetons Survey",
					SurveyDate = "02/10/2015"
				}
			};

		}
	}
}
