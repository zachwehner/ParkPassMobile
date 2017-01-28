using System;
namespace ParkPass
{
	public class Constants
	{
		public static readonly string getParksListURI = "http://parkpasspreferred:1802/";

		public static readonly string[] FacebookReadPermissions = { "public_profile", "email" };

		public static readonly string parkWebService = "http://parkpasspreferred20170104094844.azurewebsites.net/ParkasmxWebService.asmx";

		public static readonly string ParkWebServiceURL = "http://parkpasspreferred20170104094844.azurewebsites.net/api/values";
	
		public const string GoogleClientId = "1020797715272-fqtdkktccn4nc28d50ninh02bem317jc.apps.googleusercontent.com";

		public readonly string[] GoogleScopes = { "profile", "email" };


		public static readonly string BaseAddress = "http://parkpasspreferredwebapi.azurewebsites.net/";
	
	}
}
