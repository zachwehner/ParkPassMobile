using System;

using Xamarin.Forms;

namespace ParkPass
{
	public class Page1 : ContentPage
	{
		public Page1()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

