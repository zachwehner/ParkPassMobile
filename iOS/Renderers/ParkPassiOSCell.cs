using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using ParkPass;
using ParkPass.iOS.Constants;
internal class ParkPassiOSCell : UITableViewCell, INativeElementView
{
	public UILabel PassNameLabel { get; set; }
	public UILabel lblExpirationLabel { get; set; }
	public UILabel ExpirationLabel { get; set; }
	public UILabel lblUsedLabel { get; set; }
	public UILabel UsedLabel { get; set; }
	public UILabel ImagePassTypeLabel { get; set; }

	public UIImageView CellImageView { get; set; }

	public ParkPassCell NativeCell { get; private set; }
	public Element Element => NativeCell;

	public ParkPassiOSCell(string cellId, ParkPassCell cell) : base(UITableViewCellStyle.Default, cellId)
	{
		NativeCell = cell;

		SelectionStyle = UITableViewCellSelectionStyle.Gray;

		ContentView.BackgroundColor = UIColor.Clear;
		CellImageView = new UIImageView();

		CellImageView.Layer.ShadowColor = new CGColor(255, 255, 224);
		CellImageView.Layer.ShadowOffset = new CGSize(0, 1);
		CellImageView.Layer.ShadowOpacity = 1;
		CellImageView.Layer.ShadowRadius = (System.nfloat)1.0;
		CellImageView.Layer.BorderWidth = (System.nfloat)2.0;
		CellImageView.Layer.BorderColor = new CGColor(255, 255, 224);
		CellImageView.Layer.CornerRadius = 10;
		CellImageView.ClipsToBounds = true;
		PassNameLabel = new UILabel()
		{
			Font = UIFont.FromName(ParkPass.iOS.Constants.Constants.DefaultFont, 20f),
			AdjustsFontSizeToFitWidth = true,
			TextColor = ParkPass.iOS.Constants.Constants.DefaultText,
			BackgroundColor = UIColor.Clear
		};

		lblExpirationLabel = new UILabel()
		{
			Font = UIFont.FromName(ParkPass.iOS.Constants.Constants.DefaultFont, 14f),
			AdjustsFontSizeToFitWidth = true,
			TextColor = ParkPass.iOS.Constants.Constants.DefaultText,
			Text = "Expires:"
		};
		ExpirationLabel = new UILabel()
		{
			Font = UIFont.FromName(ParkPass.iOS.Constants.Constants.DefaultFont, 14f),
			
			AdjustsFontSizeToFitWidth = true,
			TextColor = ParkPass.iOS.Constants.Constants.DefaultText,
		};

		lblUsedLabel = new UILabel()
		{
			Font = UIFont.FromName(ParkPass.iOS.Constants.Constants.DefaultFont, 14f),
			AdjustsFontSizeToFitWidth = true,
			TextColor = ParkPass.iOS.Constants.Constants.DefaultText,
			Text = "Last Used:"
		};

		UsedLabel = new UILabel()
		{
			Font = UIFont.FromName(ParkPass.iOS.Constants.Constants.DefaultFont, 14f),
			TextColor = ParkPass.iOS.Constants.Constants.DefaultText,
			TextAlignment = UITextAlignment.Center,
			AdjustsFontSizeToFitWidth = true,
			BackgroundColor = UIColor.Clear

		};

		//image label visual settings
		ImagePassTypeLabel = new UILabel()
		{
			Font = UIFont.FromName("SanFranciscoDisplay-Light", 10f),
			BackgroundColor = UIColor.FromWhiteAlpha(1.0f, 0.7f),
			AdjustsFontSizeToFitWidth = true,
			TextColor = UIColor.FromRGB(59, 35, 19),
			Opaque = true,
			TextAlignment = UITextAlignment.Center
		};

		//image label overlay round corners
		ImagePassTypeLabel.Layer.ShadowColor = new CGColor(255, 255, 224);
		ImagePassTypeLabel.Layer.ShadowOffset = new CGSize(0, 1);
		ImagePassTypeLabel.Layer.ShadowOpacity = 0.7f;
		ImagePassTypeLabel.Layer.ShadowRadius = (System.nfloat)1.0;
		ImagePassTypeLabel.Layer.BorderWidth = (System.nfloat)2.0;
		ImagePassTypeLabel.Layer.BorderColor = new CGColor(255, 255, 224);

		ImagePassTypeLabel.Layer.CornerRadius = 2;

		ImagePassTypeLabel.ClipsToBounds = true;

		ImagePassTypeLabel.Opaque = true;

		ContentView.Add(CellImageView);
		ContentView.Add(PassNameLabel);
		ContentView.Add(lblExpirationLabel);
		ContentView.Add(ExpirationLabel);
		ContentView.Add(lblUsedLabel);
		ContentView.Add(UsedLabel);
		ContentView.Add(ImagePassTypeLabel);

	
	}

	public void UpdateCell(ParkPassCell cell)
	{
		PassNameLabel.Text = cell.Name;
		ImagePassTypeLabel.Text = cell.Name;
		if (cell.PurchasedDate.Length > 1)
			UsedLabel.Text = cell.PurchasedDate;

		ExpirationLabel.Text = cell.PurchasedDate;
		CellImageView.Image = GetImage(cell.ImageFilename);


		//if (cell.Status == "Unused")
		//{
		//	StatusLabel.TextColor = UIColor.FromRGB(38, 127, 0);
		//}
		//else {
		//	StatusLabel.TextColor = UIColor.FromRGB(220, 20, 60);
		//}
	}

	public UIImage GetImage(string filename)
	{
		return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile("Images/" + filename ) : null;
	}

	public override void LayoutSubviews()
	{
		base.LayoutSubviews();

		int cellImageX = 20;
		int cellImageY = 20;
		var cellImageWidth = ContentView.Bounds.Width / 2 - 40;
		var cellImageHeight = ContentView.Bounds.Height - 40;

		var cellImageLabelWidth = cellImageWidth / 2;
		var cellImageLabelHeight = cellImageHeight/6;

		var cellImageLabelX =( cellImageWidth - cellImageLabelWidth ) / 2 + cellImageY;
		var cellImageLabelY =( cellImageHeight - cellImageLabelHeight )/ 2 + cellImageX;

		PassNameLabel.Frame = new CGRect(ContentView.Bounds.Width / 2 , 15, ContentView.Bounds.Width, 25);

		lblExpirationLabel.Frame = new CGRect(ContentView.Bounds.Width / 2 , 40, 150, 25);
		ExpirationLabel.Frame = new CGRect(ContentView.Bounds.Width / 2 + 90, 40, 100, 25);

		lblUsedLabel.Frame = new CGRect(ContentView.Bounds.Width / 2 , 100, 150, 25);
		UsedLabel.Frame = new CGRect(ContentView.Bounds.Width / 2 + 90, 100, 100, 25);
		CellImageView.Frame = new CGRect(cellImageX,cellImageY, cellImageWidth,cellImageHeight);
		ImagePassTypeLabel.Frame = new CGRect(cellImageLabelX,cellImageLabelY,cellImageLabelWidth,cellImageLabelHeight);
		//	new CGRect(20, 20, ContentView.Bounds.Width / 2 - 40, ContentView.Bounds.Height - 40);
	
	}
}