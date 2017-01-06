using System;
namespace ParkPass
{
	public class ParkPassItem
	{
		
		public int ID { get; set; }

		public int ParkReferenceID { get; set; }

		public int ParkPassTypeID { get; set; }

		public ParkPassType ParkPassType { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Price { get; set; }

	}
}
