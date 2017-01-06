using System;
using System.Net;
using System.Runtime.Serialization.Json; 
namespace ParkPass
{
	public class RestClient : RestService
	{
		HttpClient client;
 

  public RestService()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
  }
}
}

