using System;
using System.Collections.Generic;
using ParkPass;
using Xamarin.Forms;
using ParkPass.Models;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ParkPass
{
	public partial class ParkPage : ContentPage
	{
		public string ParkNameValue2;


		public ParkPage()
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

		public async Task<Park[]> GetParksAsync()
		{
			var rxcui = "198440";
			var request = HttpWebRequest.Create(string.Format(@"http://rxnav.nlm.nih.gov/REST/RxTerms/rxcui/{0}/allinfo", rxcui));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if (string.IsNullOrWhiteSpace(content))
					{
						Console.Out.WriteLine("Response contained empty body...");
					}
					else {
						Console.Out.WriteLine("Response Body: \r\n {0}", content);
					}

					Assert.NotNull(content);
				}
			}
		}

		private async Task<JsonValue> FetchWeatherAsync(string url)
		{
			// Create an HTTP web request using the URL:
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
			request.ContentType = "application/json";
			request.Method = "GET";

			// Send the request to the server and wait for the response:
			using (WebResponse response = await request.GetResponseAsync())
			{
				// Get a stream representation of the HTTP web response:
				using (Stream stream = response.GetResponseStream())
				{
					// Use this stream to build a JSON document object:
					JsonValue jsonDoc = await Task.Run(() => JsonObject.Load(stream));
					Console.Out.WriteLine("Response: {0}", jsonDoc.ToString());

					// Return the JSON document:
					return jsonDoc;
				}
			}
		}


		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var park = (ParkListItem)ParkListView.SelectedItem;
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
