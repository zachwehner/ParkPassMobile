using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace ParkPass
{
	public partial class CardPage : PopupPage
	{
		public CardPage()
		{
			InitializeComponent();
		}
		public void Close_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopPopupAsync();
		}
	}
}
