using System;
using System.Collections.Generic;

namespace ParkPass.Models
{
	public class ParkListItem
	{
		public string Name { get; set;}

		public string State { get; set;}

		public string City { get; set; }

		public string Description { get; set; }

		public List<string> Amenities { get; set; }

		public string ImagePath { get; set; }

		public List<string> Passes { get; set; }
	}
}
