using System;
using System.Collections.Generic;
using ParkPass.Models;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class ParkDetailsPage : ContentPage
	{

		public string imagesource;
		public ParkDetailsPage()
		{
			InitializeComponent();


			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page, park) =>
			{

				image.Source = park.ImagePath;
				imagesource = park.ImagePath;
				parkLocationLbl.Text = park.State;
				parkDescriptionLbl.Text = park.Description;
				//lblImageName123.Source = park.ImagePath;
			});

		}
		public async void Amenities_Clicked(object sender, System.EventArgs e)

		{
			AmenitiesPage amenitiespage = new AmenitiesPage();
			amenitiespage.WidthRequest = 50;
		
			amenitiespage.InputTransparent = false;

			await Navigation.PushModalAsync(amenitiespage);

		}


	}
}
