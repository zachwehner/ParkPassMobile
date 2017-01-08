using System;
using System.Threading.Tasks;

namespace ParkPass
{
	public interface IStripe
	{
		Task<string> CreateToken(string Number, string CVC, int ExpiryYear, int ExpiryMonth);
	}
}
