using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using ParkPass;
internal class ParkPassiOSCell : UITableViewCell, INativeElementView
{
	public UILabel HeadingLabel { get; set; }
	public UILabel SubheadingLabel { get; set; }
	public UILabel PriceLabel { get; set; }
	public UILabel PurchasedDateLabel { get; set; }
	public UILabel ParkNameLabel { get; set; }
	public UILabel StatusLabel { get; set; }

	public UIImageView CellImageView { get; set; }

	public ParkPassCell NativeCell { get; private set; }
	public Element Element => NativeCell;

	public ParkPassiOSCell(string cellId, ParkPassCell cell) : base(UITableViewCellStyle.Default, cellId)
	{
		NativeCell = cell;

		SelectionStyle = UITableViewCellSelectionStyle.Gray;

		ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 224);
		CellImageView = new UIImageView();

		HeadingLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 22f),
			TextColor = UIColor.FromRGB(127, 51, 0),
			BackgroundColor = UIColor.Clear
		};

		SubheadingLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear
		};

		PurchasedDateLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear

		};

		PriceLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(0, 0, 0),
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear

		};

		ParkNameLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			BackgroundColor = UIColor.Clear


		};

		StatusLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			BackgroundColor = UIColor.Clear


		};

		ContentView.Add(CellImageView);
		ContentView.Add(HeadingLabel);
		ContentView.Add(SubheadingLabel);
		ContentView.Add(PriceLabel);
		ContentView.Add(ParkNameLabel);
		ContentView.Add(PurchasedDateLabel);
		ContentView.Add(StatusLabel);
	
	}

	public void UpdateCell(ParkPassCell cell)
	{
		HeadingLabel.Text = cell.Name;
		SubheadingLabel.Text = cell.Category;
		PriceLabel.Text = cell.PassPrice;
		ParkNameLabel.Text = cell.ParkName;
		if (cell.PurchasedDate.Length > 1)
			PurchasedDateLabel.Text = "Purchased: " + cell.PurchasedDate;
		CellImageView.Image = GetImage(cell.ImageFilename);
		StatusLabel.Text = cell.Status;
		if (cell.Status == "Unused")
		{
			StatusLabel.TextColor = UIColor.FromRGB(38, 127, 0);
		}
		else {
			StatusLabel.TextColor = UIColor.FromRGB(220, 20, 60);
		}
	}

	public UIImage GetImage(string filename)
	{
		return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile("Images/" + filename ) : null;
	}

	public override void LayoutSubviews()
	{
		base.LayoutSubviews();

		HeadingLabel.Frame = new CGRect(50, 4, ContentView.Bounds.Width - 63, 25);
		SubheadingLabel.Frame = new CGRect(50, 4, ContentView.Bounds.Width - 50, 25);
		PriceLabel.Frame = new CGRect(ContentView.Bounds.Width - 140, 18, 100, 20);
		ParkNameLabel.Frame = new CGRect(50, 18, ContentView.Bounds.Width - 63, 25);
		PurchasedDateLabel.Frame = new CGRect(40, 18, ContentView.Bounds.Width - 50, 25);
		CellImageView.Frame = new CGRect(5,4, 30, 35);
		StatusLabel.Frame = new CGRect(ContentView.Bounds.Width - 50, 18, 100, 20);
	}
}