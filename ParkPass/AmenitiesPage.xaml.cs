using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using ParkPass.Models;
namespace ParkPass
{
	public partial class AmenitiesPage : PopupPage
	{
		public AmenitiesPage()
		{
			InitializeComponent();

			AmenitiesListView.ItemsSource = new List<AmenitiesListItem>
			{
				new AmenitiesListItem {
					Name = "Grills",
					Description = "Wood Burning Grills" },
				new AmenitiesListItem {
					Name = "RV Campsites",
					Description = "500+ RV spaces"
				},
				new AmenitiesListItem {
					Name = "Bathrooms",
					Description = "Heated Bathrooms"
				}

			};
		}
	}
}
