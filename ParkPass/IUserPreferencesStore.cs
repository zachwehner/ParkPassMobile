using System;
namespace ParkPass
{
	public interface IUserPreferencesStore
	{
		/// <summary>
		/// Gets a string from persistent storage.
		/// </summary>
		/// <param name="key">The associated key.</param>
		/// <returns>Returns the associated string.</returns>
		string GetString(string key);

		/// <summary>
		/// Sets a string in persistent storage.
		/// </summary>
		/// <param name="key">The key to associate the string with.</param>
		/// <param name="value">The string to save.</param>
		void SetString(string key, string value);

		/// <summary>
		/// Gets a boolean from persistent storage.
		/// </summary>
		/// <param name="key">The associated key.</param>
		/// <returns>Returns the associated boolean.</returns>
		bool GetBool(string key);

		/// <summary>
		/// Sets a boolean in persistent storage.
		/// </summary>
		/// <param name="key">The key to associate the boolean with.</param>
		/// <param name="value">The boolean to save.</param>
		void SetBool(string key, bool value);

		/// <summary>
		/// Clears the persistent storage.
		/// </summary>
		void Reset();
	}
}
