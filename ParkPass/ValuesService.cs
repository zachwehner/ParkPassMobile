using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ParkPass
{
	public class ValuesService
	{
		public async Task<IEnumerable> GetValues(string accessToken)
		{
			HttpWebRequest request = new HttpWebRequest(new Uri(String.Format("{0}api/Values", Constants.BaseAddress)));
			request.Method = "GET";
			request.Accept = "application/json";
			request.Headers.Add("Authorization", String.Format("Bearer {0}", accessToken));

			try
			{
				HttpWebResponse httpResponse = (HttpWebResponse)(await request.GetResponseAsync());
				string json;
				using (Stream responseStream = httpResponse.GetResponseStream())
				{
					json = new StreamReader(responseStream).ReadToEnd();
				}
				List values = JsonConvert.DeserializeObject<List>(json);
				return values;
			}
			catch (Exception ex)
			{
				throw new SecurityException("Bad credentials", ex);
			}
		}
	}

}
