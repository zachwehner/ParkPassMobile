using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using ParkPass;
internal class HelpfulNumberiOSCell : UITableViewCell, INativeElementView
{
	public UILabel NameLabel { get; set; }
	public UILabel DescriptionLabel { get; set; }
	public UILabel PhoneLabel { get; set; }


	public UIImageView CellImageView { get; set; }

	public HelpfulNumberCell NativeCell { get; private set; }
	public Element Element => NativeCell;

	public HelpfulNumberiOSCell(string cellId, HelpfulNumberCell cell) : base(UITableViewCellStyle.Default, cellId)
	{
		NativeCell = cell;

		SelectionStyle = UITableViewCellSelectionStyle.Gray;

//		ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 224);
		CellImageView = new UIImageView();
		NameLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 22f),
			TextColor = UIColor.Black,
			BackgroundColor = UIColor.Clear
		};

		DescriptionLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.Black,
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear
		};

		PhoneLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.Black,
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear

		};



		ContentView.Add(CellImageView);
		ContentView.Add(NameLabel);
		ContentView.Add(DescriptionLabel);
		ContentView.Add(PhoneLabel);
	

	}

	public void UpdateCell(HelpfulNumberCell cell)
	{
		NameLabel.Text = cell.HelpfulNumberName;
		DescriptionLabel.Text = cell.Description;
		PhoneLabel.Text = cell.Phone;

		CellImageView.Image = GetImage(cell.ImageFilename);
	
	}

	public UIImage GetImage(string filename)
	{
		return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile("Images/" + filename) : null;
	}

	public override void LayoutSubviews()
	{
		base.LayoutSubviews();

		NameLabel.Frame = new CGRect(10, 4, ContentView.Bounds.Width - 63, 25);
		DescriptionLabel.Frame = new CGRect(10, 25, ContentView.Bounds.Width - 63, 25);
		PhoneLabel.Frame = new CGRect(ContentView.Bounds.Width - 100, 18, 100, 20);

	}
}