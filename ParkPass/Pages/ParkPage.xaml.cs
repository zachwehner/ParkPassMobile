using System;
using System.Collections.Generic;
using ParkPass;
using Xamarin.Forms;
using ParkPass.Models;
using System.Threading.Tasks;

namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public string ParkNameValue2;
<<<<<<< HEAD
<<<<<<< HEAD

        public void OnUseWebService(object sender, EventArgs e)
        {
            //// Create the WCF client (created using SLSvcUtil.exe on Windows)
            //ParkWebServiceClient client = new ParkWebServiceClient(
            //   new BasicHttpBinding(),
            //   new EndpointAddress("http://parkpasspreferred20170104094844.azurewebsites.net/ParkWebService.svc"));

            // Call the proxy - this should use the async versions
            //client.findAllCompleted += OnGotResults;
            //client.findAllAsync();
     

        }

        private void OnGotResults(object sender, findAllCompletedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => {
                string error = null;
                if (e.Error != null)
                    error = e.Error.Message;
                else if (e.Cancelled)
                    error = "Cancelled";

                if (!string.IsNullOrEmpty(error))
                {
                    await DisplayAlert("Error", error, "OK", "Cancel");
                }
                else
                {
                    var x = e.Result;
                }
            });
        }


        public ParkPage()
=======
		public ParkPage()
>>>>>>> parent of 7c15c75... Added Web Service
=======
		public ParkPage()
>>>>>>> parent of 7c15c75... Added Web Service
		{
			InitializeComponent();
		


			ParkListView.ItemsSource = new List<ParkListItem>
			{
				new ParkListItem {
					Name = "YellowStone",
					City = "Wyoming",
					State = "Wyoming",
					//ImagePath = "Park_Placeholder.png",
					//Description = "Yellowstone National Park is a nearly 3,500-sq.-mile wilderness recreation area atop a volcanic hot spot. Mostly in Wyoming,"
				},
				new ParkListItem {
					Name = "Yosemite",
					City = "Wyoming",
					State = "California",
					//ImagePath = "Yosemite_Placeholder.png",
					//Description = "Yosemite is one of the largest and least fragmented habitat blocks in the Sierra Nevada, and the park supports a diversity of plants and animals. The park has an elevation range from 2,127 to 13,114 feet (648 to 3,997 m) and contains five major vegetation zones: chaparral/oak woodland, lower montane forest, upper montane forest, subalpine zone, and alpine."
				},
				new ParkListItem {
					Name = "GrandTeton",
					City = "Cold City",
					State = "Wyoming",
					//ImagePath = "GrandTeton.jpg",
					//Description = "The grandest of Tetons. Look for large mountains"
				}
			};
		}

		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var park = (ParkListItem) ParkListView.SelectedItem;
			Application.Current.Properties["currentPark"] = park;
			MessagingCenter.Send<ParkPage, ParkListItem>(this, "ParkPassName", park);

			await Navigation.PopModalAsync();
	
		}


		void HandleAction()
		{
			throw new NotImplementedException();
		}
	}
}
