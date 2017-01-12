using System;
using Xamarin.Forms;
using ParkPass.iOS;
using Stripe;
using System.Threading.Tasks;

[assembly: Dependency(typeof(Stripe_iOS))]
namespace ParkPass.iOS
{
	public class Stripe_iOS : IStripe
	{
		public Stripe_iOS()
		{
		}

		public async Task<string> CreateToken(string Number, string CVC, int ExpiryYear, int ExpiryMonth)
		{
			Stripe.Card stripeCard1 = new Stripe.Card();
			stripeCard1.Number = Number;
			stripeCard1.ExpiryYear = ExpiryYear;
			stripeCard1.ExpiryMonth = ExpiryMonth;
			stripeCard1.CVC = CVC;
			var token = await Stripe.StripeClient.CreateToken(stripeCard1, "pk_test_from_stripe_dashboard");
			return token.Id;
		}
	}
}