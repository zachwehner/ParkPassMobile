using Xamarin.Forms;
namespace ParkPass
{
	public class ParkPassCell: ViewCell
	{
		public static readonly BindableProperty NameProperty =
		  BindableProperty.Create("Name", typeof(string), typeof(ParkPassCell), "");

		public string Name
		{
			get { return (string)GetValue(NameProperty); }
			set { SetValue(NameProperty, value); }
		}

		public static readonly BindableProperty ParkNameProperty =
		  BindableProperty.Create("ParkName", typeof(string), typeof(ParkPassCell), "");

		public string ParkName
		{
			get { return (string)GetValue(ParkNameProperty); }
			set { SetValue(ParkNameProperty, value); }
		}


		public static readonly BindableProperty StatusProperty =
		  BindableProperty.Create("Status", typeof(string), typeof(ParkPassCell), "");

		public string Status
		{
			get { return (string)GetValue(StatusProperty); }
			set { SetValue(StatusProperty, value); }
		}
		public static readonly BindableProperty PurchasedDateProperty =
		  BindableProperty.Create("Status", typeof(string), typeof(ParkPassCell), "");

		public string PurchasedDate
		{
			get { return (string)GetValue(PurchasedDateProperty); }
			set { SetValue(PurchasedDateProperty, value); }
		}

		public static readonly BindableProperty CategoryProperty =
		  BindableProperty.Create("Category", typeof(string), typeof(ParkPassCell), "");

		public string Category
		{
			get { return (string)GetValue(CategoryProperty); }
			set { SetValue(CategoryProperty, value); }
		}

		public static readonly BindableProperty PassPriceProperty =
		  BindableProperty.Create("PassPrice", typeof(string), typeof(ParkPassCell), "");

		public string PassPrice
		{
			get { return (string)GetValue(PassPriceProperty); }
			set { SetValue(PassPriceProperty, value); }
		}

		public static readonly BindableProperty ImageFilenameProperty =
		  BindableProperty.Create("ImageFilename", typeof(string), typeof(ParkPassCell), "");

		public string ImageFilename
		{
			get { return (string)GetValue(ImageFilenameProperty); }
			set { SetValue(ImageFilenameProperty, value); }
		}
	}
}