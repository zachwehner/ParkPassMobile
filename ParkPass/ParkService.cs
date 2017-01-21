using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ParkPass.Models;

namespace ParkPass
{
	public class ParkService : IParkService
	{

		HttpClient client;

		public ObservableCollection<Park> Parks { get; private set; }

		public ParkService()
		{
			//var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
			//var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		//	client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
		}

		public async Task<ObservableCollection<Park>> RefreshDataAsync()
		{
			try
			{
				var uri = new Uri(string.Format("http://parkpasspreferred20170104094844.azurewebsites.net/api/values"));


				var response = await client.GetAsync(uri).ConfigureAwait(false);
				response.EnsureSuccessStatusCode();


				var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
				Parks = JsonConvert.DeserializeObject<ObservableCollection<Park>>(content);
			}
			catch(HttpRequestException ex)
			{
				var y = "y";
			}
			return Parks;
		}

		//public async Task SaveTodoItemAsync(TodoItem item, bool isNewItem = false)
		//{
		//	// RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
		//	var uri = new Uri(string.Format(Constants.RestUrl, item.ID));

		//	try
		//	{
		//		var json = JsonConvert.SerializeObject(item);
		//		var content = new StringContent(json, Encoding.UTF8, "application/json");

		//		HttpResponseMessage response = null;
		//		if (isNewItem)
		//		{
		//			response = await client.PostAsync(uri, content);
		//		}
		//		else {
		//			response = await client.PutAsync(uri, content);
		//		}

		//		if (response.IsSuccessStatusCode)
		//		{
		//			Debug.WriteLine(@"				TodoItem successfully saved.");
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		Debug.WriteLine(@"				ERROR {0}", ex.Message);
		//	}
		//}

		//public async Task DeleteTodoItemAsync(string id)
		//{
		//	// RestUrl = http://developer.xamarin.com:8081/api/todoitems{0}
		//	var uri = new Uri(string.Format(Constants.RestUrl, id));

		//	try
		//	{
		//		var response = await client.DeleteAsync(uri);

		//		if (response.IsSuccessStatusCode)
		//		{
		//			Debug.WriteLine(@"				TodoItem successfully deleted.");
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		Debug.WriteLine(@"				ERROR {0}", ex.Message);
		//	}
		//}
	}
}
