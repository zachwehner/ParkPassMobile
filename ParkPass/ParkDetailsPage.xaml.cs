using System;
using System.Collections.Generic;
using ParkPass.Models;
using Xamarin.Forms;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Extensions;
using System.Threading.Tasks;

namespace ParkPass
{
	public partial class ParkDetailsPage : ContentPage
	{
		public string parkNameValue;
		public string imagesource;
		public ParkListItem selectedPark = null;

		public ParkDetailsPage()
		{
			InitializeComponent();
			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page, park) =>
			{

				this.ToolbarItems[0].Text = park.Name;
			});

			if (Application.Current.Properties.ContainsKey("currentPark"))
			{
				selectedPark = Application.Current.Properties["currentPark"] as ParkListItem;
			}
		

			if (selectedPark == null)
			{
				parkNameValue = "Please Choose A Park";

				parkDescriptionLbl.Text = "Get started by selecting a park above!";
				parkDescriptionLbl.TextColor = Color.FromHex("FFFFFF");
				parkDescriptionLbl.FontSize = 24;
				btnFood.IsVisible = false;
				btnPass.IsVisible = false;
				btnHelpful.IsVisible = false;
				btnAmenties.IsVisible = false;

				blueHR.IsVisible = false;
				bottombluehr.IsVisible = false;
					passListView.IsVisible = false;
					topwhiteHR.IsVisible = false;
					bottomwhiteHR.IsVisible = false;
			}
			else {
				ParkPassLogo.IsVisible = false;
				image.Source = selectedPark.ImagePath;
				imagesource = selectedPark.ImagePath;
				parkLocationLbl.Text = selectedPark.State;
				parkDescriptionLbl.Text = selectedPark.Description;
				parkNameValue = selectedPark.Name;

			}
				this.ToolbarItems.Add(new ToolbarItem(parkNameValue, null, ParkName_Clicked, ToolbarItemOrder.Default, 0));
				this.ToolbarItems.Add(new ToolbarItem(null, null, Purchase_Clicked, ToolbarItemOrder.Default, 1));
				this.ToolbarItems.Add(new ToolbarItem("Purchase", "purchase.png", Purchase_Clicked, ToolbarItemOrder.Default, 2));
			


			
			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page, park) =>
			{

				this.ToolbarItems[0].Text = park.Name;
			});

			MessagingCenter.Subscribe<ParkPage, ParkListItem>(this, "ParkPassName", (page, park) =>
			{

				image.Source = park.ImagePath;
				imagesource = park.ImagePath;
				parkLocationLbl.Text = park.State;
				parkDescriptionLbl.Text = park.Description;
				btnFood.IsVisible = true;
				btnPass.IsVisible = true;
				btnHelpful.IsVisible = true;
				btnAmenties.IsVisible = true;
				ParkPassLogo.IsVisible = false;
				blueHR.IsVisible = true;
				bottombluehr.IsVisible = true;
				passListView.IsVisible = true;
				topwhiteHR.IsVisible = true;
				bottomwhiteHR.IsVisible = true;
				//lblImageName123.Source = park.ImagePath;
			});

		}
		public async void Amenities_Clicked(object sender, System.EventArgs e)

		{
			UserAnimation useranimation = new UserAnimation();

			AmenitiesPage amenitiesPage = new AmenitiesPage();
			amenitiesPage.WidthRequest = 50;
			amenitiesPage.Padding = 40;
			amenitiesPage.HeightRequest = 100;
			bool animate = true;
			await Navigation.PushPopupAsync(amenitiesPage, animate);

		}


		public async void HelpfulNumbers_Clicked(object sender, System.EventArgs e)
		{
			UserAnimation useranimation = new UserAnimation();

			HelpfulNumbersPage helpfulNumbersPage = new HelpfulNumbersPage();
			helpfulNumbersPage.WidthRequest = 50;
			helpfulNumbersPage.Padding = 40;
			helpfulNumbersPage.HeightRequest = 100;
			bool animate = true;
			await Navigation.PushPopupAsync(helpfulNumbersPage);
		}
		public async void ParkName_Clicked()
		{
			var parkPage = new ParkPage();
			//parkPage.BindingContext = MainPage.BindingContextProperty;

			await Navigation.PushModalAsync(parkPage);

			var x = parkPage.ParkNameValue2;

		}

		public async void Purchase_Clicked(object sender, System.EventArgs e)

		{

			await Navigation.PushModalAsync(new ParkPassPage());

		}

		public async void Purchase_Clicked()
		{
			await Navigation.PushModalAsync(new ParkPassPage());

		}
	}
}
