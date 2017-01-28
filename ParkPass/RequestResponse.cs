using System;
using System.Net;

namespace ParkPass
{
	public class RequestResponse
	{
		public BadRequestResponse badRequestReponse { get; set; }
		public bool Successful { get; set;} 
		public HttpStatusCode httpStatusCode{get; set;}
	}
}
