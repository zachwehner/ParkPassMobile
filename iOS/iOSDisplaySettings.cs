using System;
using UIKit;

namespace ParkPass.iOS
{
	public class iOSDisplaySettings : IDisplaySettings
	{
		public iOSDisplaySettings()
		{
			GetHeight();
			GetWidth();
		}
		public int GetHeight()
		{
			return (int)UIScreen.MainScreen.Bounds.Height;
		}

		public int GetWidth()
		{
			return (int)UIScreen.MainScreen.Bounds.Width;
		}
	}
}


