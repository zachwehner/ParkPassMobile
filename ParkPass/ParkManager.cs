
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ParkPass.Models;

namespace ParkPass
{
	public class ParkManager
	{
		IParkService parkService;

		public ParkManager(IParkService service)
		{			parkService = service;
		}

		public Task<ObservableCollection<Park>> GetTasksAsync()
		{
			

			return parkService.RefreshDataAsync();
		}

		//public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
		//{
		//	return restService.SaveTodoItemAsync(item, isNewItem);
		//}

		//public Task DeleteTaskAsync(TodoItem item)
		//{
		//	return restService.DeleteTodoItemAsync(item.ID);
		//}




	}
}



