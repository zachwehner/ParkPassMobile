using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ParkPass
{
	class RegisterService
	{
		HttpClient client;


		public async Task<RequestResponse> Register(string username, string password, string confirmPassword)
		{

			HttpResponseMessage response = null;
			BadRequestResponse badRequestResponse;
			RequestResponse requestReponse = new RequestResponse();

			RegisterModel model = new RegisterModel
			{
				ConfirmPassword = confirmPassword,
				Password = password,
				Email = username
			};

			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

			try
			{
				Uri uri = new Uri(String.Format("{0}api/Account/Register", Constants.BaseAddress));
				string json = JsonConvert.SerializeObject(model);
				byte[] bytes = Encoding.UTF8.GetBytes(json);
				var requestContent = new StringContent(json, Encoding.UTF8, "application/json");

				response = await client.PostAsync(uri, requestContent).ConfigureAwait(false);

				var responseMessage = response.Content.ReadAsStringAsync().Result;

				if (response.IsSuccessStatusCode)
					requestReponse.Successful = true;
				else {
					badRequestResponse = JsonConvert.DeserializeObject<BadRequestResponse>(responseMessage);
					requestReponse.badRequestReponse = badRequestResponse;
					requestReponse.Successful = false;
				}

			}
			catch (HttpRequestException ex)
			{
				requestReponse.Successful = false;
			}

			return requestReponse;



		}
	}
}
