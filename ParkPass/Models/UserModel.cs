// -----------------------------------------------------------------------
// <copyright file="UserModel.cs" company="Automated Transportation Network">
// Copyright (C) Automated Transportation Network All Rights Reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ParkPass
{
	/// <summary>
	/// Model representing a user.
	/// </summary>
	public class UserModel
	{
		/// <summary>
		/// Gets or sets the user's user name.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the user's first name.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the user's last name.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Gets the user's full name.
		/// </summary>
		public string FullName
		{
			get
			{
				return $"{this.FirstName} {this.LastName}";
			}
		}

		/// <summary>
		/// Gets or sets the user's email address.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the user's provider.
		/// </summary>
		public string Provider { get; set; }
	}
}
