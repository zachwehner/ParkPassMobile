using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ParkPass;

namespace ParkPass
{

	public class LoginService
	{
		HttpClient client;

		public LoginService()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		}

		public async Task<RequestResponse> Login(string username, string password)
		{
			RequestResponse requestResponse = new RequestResponse();
			try
			{
				Uri uri = new Uri(String.Format("{0}token", Constants.BaseAddress));

				var requestContent = new StringContent(string.Format("grant_type=password&username={0}&password={1}", System.Net.WebUtility.UrlEncode(username),
		   WebUtility.UrlEncode(password)), Encoding.UTF8, "application/x-www-form-urlencoded");

				var response = await client.PostAsync(uri, requestContent).ConfigureAwait(false);

				var responseMessage = response.Content.ReadAsStringAsync().Result;

				if (response.IsSuccessStatusCode)
				{
					AccessToken accessToken = AccessToken.Create(responseMessage);
					UserContext.SetAccessToken(accessToken);
					App.UserToken = accessToken;
					requestResponse.Successful = true;
				}
				else {
					requestResponse.badRequestReponse = JsonConvert.DeserializeObject<BadRequestResponse>(responseMessage);
					requestResponse.Successful = false;
				}

			}
			catch (HttpRequestException ex)
			{
				requestResponse.Successful = false;
			}
			return requestResponse;
		}


		public async Task<IEnumerable<ExternalLoginViewModel>> GetExternalLoginProviders()
		{
			RequestResponse requestResponse = new RequestResponse();
			IEnumerable<ExternalLoginViewModel> externalLoginModel = new List<ExternalLoginViewModel>();

			try
			{
				var uri = new Uri(String.Format("{0}api/Account/ExternalLogins?returnUrl=%2F&generateState=true", Constants.BaseAddress));

				var response = await client.GetAsync(uri).ConfigureAwait(false);
				var responseMessage = response.Content.ReadAsStringAsync().Result;

				if (response.IsSuccessStatusCode)
				{
					 externalLoginModel = JsonConvert.DeserializeObject<List<ExternalLoginViewModel>>(responseMessage);
				
				}
				else {
					
					requestResponse.Successful = false;
				}

			}
			catch (HttpRequestException ex)
			{
				requestResponse.Successful = false;
			}
			return externalLoginModel;
	}


		public async Task<IEnumerable<ExternalLoginViewModel>> FacebookAuth(ExternalLoginViewModel externalLoginViewModel, string username, string password)
		{
			RequestResponse requestResponse = new RequestResponse();
			try
			{
				Uri uri = new Uri(string.Format("grant_type=password&username={0}&password={1}", System.Net.WebUtility.UrlEncode(username), System.Net.WebUtility.UrlEncode(password)));
					var requestContent = new StringContent(string.Format("grant_type=password&username={0}&external={1}&password={2}", System.Net.WebUtility.UrlEncode(username),externalLoginViewModel.Name,
		  		 WebUtility.UrlEncode(password)), Encoding.UTF8, "application/x-www-form-urlencoded");

				var response = await client.PostAsync(uri, requestContent).ConfigureAwait(false);

				var responseMessage = response.Content.ReadAsStringAsync().Result;

				if (response.IsSuccessStatusCode)
				{
					AccessToken accessToken = AccessToken.Create(responseMessage);

					App.UserToken = accessToken;
					requestResponse.Successful = true;
				}
				else {
					requestResponse.badRequestReponse = JsonConvert.DeserializeObject<BadRequestResponse>(responseMessage);
					requestResponse.Successful = false;
				}

			}
			catch (HttpRequestException ex)
			{
				requestResponse.Successful = false;
			}
			return (System.Collections.Generic.IEnumerable<ParkPass.ExternalLoginViewModel>)requestResponse;

		}


}
}

