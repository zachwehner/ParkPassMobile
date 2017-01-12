using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkPass
{
	public interface ISoapService
	{
		Task<List<ParkPassItem>> RefreshDataAsync();

		//Task SaveTodoItemAsync(ParkPassItem item, bool isNewItem);

		//Task DeleteTodoItemAsync(string id);
	}
}




