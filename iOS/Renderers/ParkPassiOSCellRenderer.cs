using CustomRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(ParkPassCell), typeof(ParkPassiOSCellRenderer))]
namespace CustomRenderer.iOS
{
	public class ParkPassiOSCellRenderer : ViewCellRenderer
	{
		ParkPassiOSCell cell;

		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var nativeCell = (ParkPassCell)item;

			cell = reusableCell as ParkPassiOSCell;
			if (cell == null)
				cell = new ParkPassiOSCell(item.GetType().FullName, nativeCell);
			else
				cell.NativeCell.PropertyChanged -= OnNativeCellPropertyChanged;

			nativeCell.PropertyChanged += OnNativeCellPropertyChanged;
			cell.UpdateCell(nativeCell);
			return cell;
		}
		public void OnNativeCellPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			var nativeCell = (ParkPassCell)sender;
			if (e.PropertyName == ParkPassCell.NameProperty.PropertyName)
			{
				cell.PassNameLabel.Text = nativeCell.Name;
			}
			else if (e.PropertyName == ParkPassCell.CategoryProperty.PropertyName)
			{
				cell.UsedLabel.Text = nativeCell.Category;
			}
			else if (e.PropertyName == ParkPassCell.ImageFilenameProperty.PropertyName)
			{
				cell.CellImageView.Image = cell.GetImage(nativeCell.ImageFilename);
			}
		}
        
    }
}