using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParkPass
{
	public partial class BarcodePage : ContentPage
	{
		public BarcodePage()
		{
			InitializeComponent();  
		}
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
			Navigation.PopModalAsync();
			Navigation.PopModalAsync();
		

		}
	}
}
