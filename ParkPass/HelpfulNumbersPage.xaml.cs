using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using ParkPass.Models;
using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;

namespace ParkPass
{
	public partial class HelpfulNumbersPage : PopupPage
	{
		public HelpfulNumbersPage()
		{
			InitializeComponent();

			helpfulNumbersListView.ItemsSource = new List<HelpfulNumberCell>
			{
					new HelpfulNumberCell {
					HelpfulNumberName = "Ranger",
					Phone = "210-345-1937",
					Description = "Local Rangers Number" },
				new HelpfulNumberCell {
					HelpfulNumberName = "Emergency",
					Phone = "911",
					Description = "In case of Emergency"
				},
				new HelpfulNumberCell {
					HelpfulNumberName = "Campsite Reservations",
					Phone = "503-569-2676",
					Description = "Reserve A Campsite"
				}

			};
			Animation = new UserAnimation();
		}

		void Close_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopPopupAsync();
		}
	}
}
