using CustomRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(HelpfulNumberCell), typeof(HelpfulNumberiOSCellRenderer))]
namespace CustomRenderer.iOS
{
	public class HelpfulNumberiOSCellRenderer : ViewCellRenderer
	{
		HelpfulNumberiOSCell cell;

		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var nativeCell = (HelpfulNumberCell)item;

			cell = reusableCell as HelpfulNumberiOSCell;
			if (cell == null)
				cell = new HelpfulNumberiOSCell(item.GetType().FullName, nativeCell);
			else
				cell.NativeCell.PropertyChanged -= OnNativeCellPropertyChanged;

			nativeCell.PropertyChanged += OnNativeCellPropertyChanged;
			cell.UpdateCell(nativeCell);
			return cell;
		}
		public void OnNativeCellPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			var nativeCell = (HelpfulNumberCell)sender;
			if (e.PropertyName == HelpfulNumberCell.HelpfulNumberNameProperty.PropertyName)
			{
				cell.NameLabel.Text = nativeCell.HelpfulNumberName;
			}
			else if (e.PropertyName == HelpfulNumberCell.DescriptionProperty.PropertyName)
			{
				cell.DescriptionLabel.Text = nativeCell.Description;
			}
			else if (e.PropertyName == HelpfulNumberCell.ImageFilenameProperty.PropertyName)
			{
				cell.CellImageView.Image = cell.GetImage(nativeCell.ImageFilename);
			}
		}
	}
}
