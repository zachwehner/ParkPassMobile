using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using ParkPass.iOS.ParkWebService;
namespace ParkPass.iOS
{
	public class SoapService : ISoapService
	{
		ParkasmxWebServiceSoapClient parkService;

		public List<ParkPass.iOS.ParkWebService.Park> Parks { get; private set; }

		public SoapService()
		{

			parkService = new ParkPass.iOS.parkpasspreferred20170104094844.azurewebsites.net_2.ParkasmxWebService (Constants.parkWebService);
		}

		Park ToASMXServiceTodoItem(ParkPass.Models.Park parkitem)
		{
			return new Park
			{
				ID = parkitem.ID,
				Name = parkitem.Name

			};
		}

		static ParkPass.Models.Park FromASMXServiceTodoItem(Park park)
		{
			return new ParkPass.Models.Park
			{
				ID = park.ID,
				Name = park.Name

			};
		}

		public async Task<List<ParkPass.Models.Park>> RefreshDataAsync()
		{
			Parks = new List<ParkPass.Models.Park>();

			try
			{

				//	List<ParkPass.iOS.WebServices.Park> parkItems = await Task.Factory.FromAsync<ParkPass.iOS.WebServices.Park[]>(null, ParkasmxWebService.getAllOperationCompleted);
				List<ParkPass.iOS.WebServices.Park> parkItems = await Task.Factory.FromAsync<Park[]>(getAllCompletedEventArgs, getAllCompletedEventArgs, null, TaskCreationOptions.None);
				//List<ParkPass.iOS.WebServices.Park> parkItems = await Task.Factory.FromAsync<ParkPass.iOS.WebServices.Park[]>(getAllOperationCompleted, ParkasmxWebService.EndGetParks, null, TaskCreationOptions.None);

				foreach (var park in parkItems)
				{
					Parks.Add(FromASMXServiceTodoItem(park));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"				ERROR {0}", ex.Message);
			}

			return Parks;
		}

		//public async Task SaveTodoItemAsync(TodoItem item, bool isNewItem = false)
		//{
		//	try
		//	{
		//		var todoItem = ToASMXServiceTodoItem(item);
		//		//if (isNewItem)
		//		//{
		//		//	await Task.Factory.FromAsync(ParkasmxWebService.BeginCreatePark, todoService.EndCreateTodoItem, todoItem, TaskCreationOptions.None);
		//		//}
		//		//else {
		//		//	await Task.Factory.FromAsync(ParkasmxWebService.BeginEditTodoItem, todoService.EndEditTodoItem, todoItem, TaskCreationOptions.None);
		//		//}
		//	}
		//	catch (SoapException se)
		//	{
		//		Debug.WriteLine(@"				{0}", se.Message);
		//	}
		//	catch (Exception ex)
		//	{
		//		Debug.WriteLine(@"				ERROR {0}", ex.Message);
		//	}
		//}

		//public async Task DeleteTodoItemAsync(string id)
		//{
		//	try
		//	{
		//		await Task.Factory.FromAsync(todoService.BeginDeleteTodoItem, todoService.EndDeleteTodoItem, id, TaskCreationOptions.None);
		//	}
		//	catch (SoapException se)
		//	{
		//		Debug.WriteLine(@"				{0}", se.Message);
		//	}
		//	catch (Exception ex)
		//	{
		//		Debug.WriteLine(@"				ERROR {0}", ex.Message);
		//	}
		//}

		Task<List<ParkPassItem>> ISoapService.RefreshDataAsync()
		{
			throw new NotImplementedException();
		}
	}
}