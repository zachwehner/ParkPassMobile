using CustomRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass;
using System.ComponentModel;
using ParkPass.iOS;

	[assembly: ExportRenderer(typeof(AmenityCell), typeof(AmenityiOSCellRenderer))]
	namespace CustomRenderer.iOS
	{

	public class AmenityiOSCellRenderer : ViewCellRenderer
		{
			AmenityiOSCell cell;

			public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
			{
				var nativeCell = (AmenityCell)item;

				cell = reusableCell as AmenityiOSCell;
				if (cell == null)
					cell = new AmenityiOSCell(item.GetType().FullName, nativeCell);
				else
					cell.NativeCell.PropertyChanged -= OnNativeCellPropertyChanged;

				nativeCell.PropertyChanged += OnNativeCellPropertyChanged;
				cell.UpdateCell(nativeCell);
				return cell;
			}
			public void OnNativeCellPropertyChanged(object sender, PropertyChangedEventArgs e)
			{
				var nativeCell = (AmenityCell)sender;
				if (e.PropertyName == AmenityCell.AmenityNameProperty.PropertyName)
				{
					cell.NameLabel.Text = nativeCell.AmenityName;
				}
				else if (e.PropertyName == AmenityCell.DescriptionProperty.PropertyName)
				{
					cell.DescriptionLabel.Text = nativeCell.Description;
				}
				else if (e.PropertyName == AmenityCell.ImageFilenameProperty.PropertyName)
				{
					cell.CellImageView.Image = cell.GetImage(nativeCell.ImageFilename);
				}
			}
		}
	}
	
