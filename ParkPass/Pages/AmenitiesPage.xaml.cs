using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using ParkPass.Models;
using Rg.Plugins.Popup.Extensions;
namespace ParkPass
{
	public partial class AmenitiesPage : PopupPage
	{
		public AmenitiesPage()
		{
			InitializeComponent();

			AmenitiesListView.ItemsSource = new List<AmenityCell>
			{
				new AmenityCell {
					ImageFilename = "Grill.png",
					AmenityName = "Grills",
					Description = "Wood Burning Grills" },
				new AmenityCell {
					ImageFilename= "RV.png",
					AmenityName = "RV Campsites",
					Description = "500+ RV spaces"
				},
				new AmenityCell {
					ImageFilename = "Restrooms.png",
					AmenityName = "Restrooms",
					Description = "Heated Restrooms"
				}

			};
		}
		void Close_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopPopupAsync();
		}
	}
}
