using System;
using System.Collections.Generic;
using ParkPass.Models;

namespace ParkPass.Models
{
	public class ParkListItem
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string ZipCode { get; set; }

		public string ParkDescription { get; set; }

		public List<ParkPassItem> ParkPasses { get; set; }

		public List<ParkDetail> ParkDetails { get; set; }

	}
}
