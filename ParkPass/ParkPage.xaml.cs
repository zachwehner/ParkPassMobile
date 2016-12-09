using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public ParkPage()
		{
			InitializeComponent();


			ParkListView.ItemsSource = new List<ParkListItem>           {
				new ParkListItem {
					Name = "YellowStone",
					City = "Wyoming",
					State = "Wyoming"
				},
				new ParkListItem {
					Name = "Grand Tetons",
					City = "Wyoming",
					State = "Wyoming"
				},
				new ParkListItem {
					Name = "Glacier",
					City = "Cold City",
					State = "Alaska"
				}
			};
		}
	}
}
