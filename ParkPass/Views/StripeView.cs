// -----------------------------------------------------------------------
// <copyright file="StripeView.cs" company="Automated Transportation Network">
// Copyright (C) Automated Transportation Network All Rights Reserved.
// </copyright>
// -----------------------------------------------------------------------
using System;
using Xamarin.Forms;
//using Stripe;
using System.Threading.Tasks;

namespace ParkPass.Views
{
	/// <summary>
	/// The stripe (credit card imput) view being natively rendered.
	/// </summary>
	public class StripeView : View
	{
		
			  public static readonly BindableProperty StripeViewProperty =
BindableProperty.Create<StripeView, string>(p => p.GUID, null, BindingMode.TwoWay);

		public static readonly BindableProperty NumberProperty =
			BindableProperty.Create<StripeView, string>(p => p.Number, null, BindingMode.TwoWay);

		public string Number
		{
			get { return (string)GetValue(NumberProperty); }
			set { SetValue(NumberProperty, value); }
		} // it would rise ElementPropertyChanged event}
		public string GUID
		{
			get { return (string)GetValue(StripeViewProperty); }
			set { SetValue(StripeViewProperty, value); }
		} // it would rise ElementPropertyChanged event}
		public string CVC { get; set; }
		public string Name { get; set; }
		public int ExpiryYear { get; set; }
		public int ExpiryMonth { get; set; }


		public class Card
		{
			public string Number { get; set; }
			public string CVC { get; set; }
			public string Name { get; set; }
			public int ExpiryYear { get; set; }
			public int ExpiryMonth { get; set; }
			public string AddressCity { get; set; }
			public string AddressCountry { get; set; }
		}
	
}


    
}
