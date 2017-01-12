using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using ParkPass;
using RestSharp;

namespace ParkPass.iOS
{
	public class RestService :IRestService
	{

		public async Task<string> GetParks()
		{
	var request = new RestRequest(string.Format("{0}/allinfo", rxcui));
			request.RequestFormat = DataFormat.Json;
			var response = Client.Execute(request);
			if (string.IsNullOrWhiteSpace(response.Content) || response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				return null;
			}
			rxTerm = DeserializeRxTerm(response.Content);
				}
			}
		}

	}
}
