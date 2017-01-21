using System;
using System.Collections.Generic;
using ParkPass;
using Xamarin.Forms;
using ParkPass.Models;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public string ParkNameValue2;
		HttpClient client;

		public ParkPage()
		{


			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;

			InitializeComponent();

		}




		protected async override void OnAppearing()
		{
			base.OnAppearing();


			ParkListView.ItemsSource = await App.ParkManager.GetTasksAsync();

		}






		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var park = (Park)ParkListView.SelectedItem;
			Application.Current.Properties["currentPark"] = park;
			MessagingCenter.Send<ParkPage, Park>(this, "ParkPassName", park);

			await Navigation.PopModalAsync();

		}


		void HandleAction()
		{
			throw new NotImplementedException();
		}
	}
}
