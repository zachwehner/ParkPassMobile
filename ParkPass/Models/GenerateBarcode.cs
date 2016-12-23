using System;
using ZXing.Net.Mobile.Forms;
using ZXing.Common;
using ZXing;
namespace ParkPass
{
	public class GenerateBarcode
	{
		public GenerateBarcode()
		{

		}
		public static byte[] GetQRCode(string code)
		{
	
			var writer = new BarcodeWriter
			{
				Format = BarcodeFormat.QR_CODE,
				Options = new ZXing.Common.EncodingOptions
				{
					Height = 600,
					Width = 600
				}
			};
			return writer.Write(code);
		}
		}

}
