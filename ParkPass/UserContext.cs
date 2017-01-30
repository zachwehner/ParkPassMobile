using System;
using Newtonsoft.Json;

namespace ParkPass
{
	public class UserContext
	{
		private static AccessToken accessToken = null;

		private static readonly string AccessTokenKey = "accesstoken";


		 public static AccessToken GetAccessToken()
			{
			if (accessToken == null)
			{
				var accessTokenString = App.UserPreferencesStore.GetString(AccessTokenKey);
				if (!string.IsNullOrWhiteSpace(accessTokenString))
				{
					accessToken = JsonConvert.DeserializeObject<AccessToken>(accessTokenString);
				}
			}
			return accessToken;
		}

		
		public static void SetAccessToken(AccessToken token)
		{
			accessToken = token;
			App.UserPreferencesStore.SetString(AccessTokenKey, JsonConvert.SerializeObject(token));
		
		}
	}
}
