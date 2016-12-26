using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using ParkPass;

namespace ParkPass.iOS
{
	internal class AmenityiOSCell : UITableViewCell, INativeElementView{
		
		public UILabel NameLabel { get; set; }
		public UILabel DescriptionLabel { get; set; }

	public UIImageView CellImageView { get; set; }

	public AmenityCell NativeCell { get; private set; }
	public Element Element => NativeCell;
	
		public AmenityiOSCell(string cellId, AmenityCell cell) : base(UITableViewCellStyle.Default, cellId)
	{
		NativeCell = cell;

		SelectionStyle = UITableViewCellSelectionStyle.Gray;

		ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 224);
		CellImageView = new UIImageView();

		NameLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 22f),
			TextColor = UIColor.FromRGB(127, 51, 0),
			BackgroundColor = UIColor.Clear
		};

		DescriptionLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear
		};


		ContentView.Add(CellImageView);
		ContentView.Add(NameLabel);
		ContentView.Add(DescriptionLabel);



	}

	public void UpdateCell(AmenityCell cell)
	{
		NameLabel.Text = cell.AmenityName;
		DescriptionLabel.Text = cell.Description;
		CellImageView.Image = GetImage(cell.ImageFilename);
	}

	public UIImage GetImage(string filename)
	{
		return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile("Images/" + filename) : null;
	}

	public override void LayoutSubviews()
	{
		base.LayoutSubviews();

		NameLabel.Frame = new CGRect(ContentView.Bounds.Width - 200, 4, ContentView.Bounds.Width - 63, 25);
		DescriptionLabel.Frame = new CGRect(ContentView.Bounds.Width - 200, 18, ContentView.Bounds.Width - 50, 25);
		CellImageView.Frame = new CGRect(40, 4, 30, 35);

	}
	}
}
