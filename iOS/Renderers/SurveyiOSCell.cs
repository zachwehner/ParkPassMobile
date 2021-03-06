﻿using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using ParkPass;

internal class SurveyiOSCell : UITableViewCell, INativeElementView
{
	
		public UILabel NameLabel { get; set; }
	public UILabel DescriptionLabel { get; set; }
	public UILabel PhoneLabel { get; set; }


	public UIImageView CellImageView { get; set; }

	public SurveyCell NativeCell { get; private set; }
	public Element Element => NativeCell;

	public SurveyiOSCell(string cellId, SurveyCell cell) : base(UITableViewCellStyle.Default, cellId)
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

		PhoneLabel = new UILabel()
		{
			Font = UIFont.FromName("AmericanTypewriter", 12f),
			TextColor = UIColor.FromRGB(38, 127, 0),
			TextAlignment = UITextAlignment.Center,
			BackgroundColor = UIColor.Clear

		};



		ContentView.Add(CellImageView);
		ContentView.Add(NameLabel);
		ContentView.Add(DescriptionLabel);
		ContentView.Add(PhoneLabel);


	}

	public void UpdateCell(SurveyCell cell)
	{
		NameLabel.Text = cell.SurveyName;
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

		NameLabel.Frame = new CGRect(10, 4, ContentView.Bounds.Width - 63, 25);
		DescriptionLabel.Frame = new CGRect(10, 18, ContentView.Bounds.Width - 50, 25);
		PhoneLabel.Frame = new CGRect(ContentView.Bounds.Width - 100, 18, 100, 20);

	}
}
