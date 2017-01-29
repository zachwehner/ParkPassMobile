using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace ParkPass
{
	/// <summary>
	/// Represents the data of an access token.
	/// </summary>
	public class AccessToken
	{
		/// <summary>
		/// Gets or sets the value of the token.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the type of token.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the date time that the token was created.
		/// </summary>
		public DateTime? HalfExpiration { get; set; }

		/// <summary>
		/// Gets or sets the date time that the token will expire.
		/// </summary>
		public DateTime? Expiration { get; set; }

		/// <summary>
		/// Gets a value indicating whether the token is expired.
		/// </summary>
		public bool NeedsRefresh
		{
			get
			{
				return this.HalfExpiration.HasValue && DateTime.Now > this.HalfExpiration.Value;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the token is expired.
		/// </summary>
		public bool IsExpired
		{
			get
			{
				return this.Expiration.HasValue && DateTime.Now > this.Expiration.Value;
			}
		}

		public string RefreshToken { get; set; }

		public string UserName { get; set; }

		public string Email { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public List<string> Roles { get; set; }


		public string Error { get; set; }


		public string ErrorDescription { get; set; }


		public AccessToken()
		{
			this.Type = "Bearer";
			this.Roles = new List<string>();
		}


		public static AccessToken Create(string jsonToken)
		{
			var tokenData = new
			{
				Token_Type = string.Empty,
				Access_Token = string.Empty,
				Expires_In = string.Empty,
				Refresh_Token = string.Empty,
				Username = string.Empty,
				FirstName = string.Empty,
				LastName = string.Empty,
				Email = string.Empty,
				Error = string.Empty,
				Error_Description = string.Empty
			};

			var tokenInfo = JsonConvert.DeserializeAnonymousType(jsonToken, tokenData);

			if (tokenInfo != null)
			{
				int tempInt;
				int expiresIn = int.TryParse(tokenInfo.Expires_In, out tempInt) ? tempInt : 3600;
				return new AccessToken()
				{
					Value = tokenInfo.Access_Token,
					Type = tokenInfo.Token_Type,
					Expiration = DateTime.Now.AddSeconds(expiresIn),
					HalfExpiration = DateTime.Now.AddSeconds(expiresIn / 2),
					RefreshToken = tokenInfo.Refresh_Token,
					UserName = tokenInfo.Username,
					FirstName = tokenInfo.FirstName,
					LastName = tokenInfo.LastName,
					Email = tokenInfo.Email,
					Error = tokenInfo.Error,
					ErrorDescription = tokenInfo.Error_Description
				};
			}
			else
			{
				return new AccessToken() { Error = "Unable to parse.", ErrorDescription = "Unable to parse." };
			}
		}

		public override string ToString()
		{
			return WebUtility.UrlEncode(JsonConvert.SerializeObject(this));
		}
	}
}
