using System;
using Foundation;

namespace ParkPass.iOS
{
	public class UserPreferences : IUserPreferencesStore
	{
		public string GetString(string key)
		{
			return NSUserDefaults.StandardUserDefaults.StringForKey(key);
		}

		public void SetString(string key, string value)
		{
			NSUserDefaults.StandardUserDefaults.SetString(value, key);
		}

		public bool GetBool(string key)
		{
			return NSUserDefaults.StandardUserDefaults.BoolForKey(key);
		}

		public void SetBool(string key, bool value)
		{
			NSUserDefaults.StandardUserDefaults.SetBool(value, key);
		}

		public void Reset()
		{
			NSUserDefaults.StandardUserDefaults.RemovePersistentDomain(NSBundle.MainBundle.BundleIdentifier);
		}
	}
}
