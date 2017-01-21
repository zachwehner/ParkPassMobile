using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ParkPass.Models;

namespace ParkPass
{
	public interface IParkService
	{
		Task<ObservableCollection<Park>> RefreshDataAsync();
	}
}


