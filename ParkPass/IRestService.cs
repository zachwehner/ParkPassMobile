using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ParkPass
{
	public interface IRestService
	{
		Task<List<ParkPassItem>> GetParksList();
	}
}
