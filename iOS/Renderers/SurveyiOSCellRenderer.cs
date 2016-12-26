using CustomRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ParkPass;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(SurveyCell), typeof(SurveyiOSCellRenderer))]
namespace CustomRenderer.iOS
{

	public class SurveyiOSCellRenderer : ViewCellRenderer
	{
		SurveyiOSCell cell;

		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var nativeCell = (SurveyCell)item;

			cell = reusableCell as SurveyiOSCell;
			if (cell == null)
				cell = new SurveyiOSCell(item.GetType().FullName, nativeCell);
			else
				cell.NativeCell.PropertyChanged -= OnNativeCellPropertyChanged;

			nativeCell.PropertyChanged += OnNativeCellPropertyChanged;
			cell.UpdateCell(nativeCell);
			return cell;
		}
		public void OnNativeCellPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			var nativeCell = (SurveyCell)sender;
			if (e.PropertyName == SurveyCell.SurveyNameProperty.PropertyName)
			{
				cell.NameLabel.Text = nativeCell.SurveyName;
			}
			else if (e.PropertyName == SurveyCell.DescriptionProperty.PropertyName)
			{
				cell.DescriptionLabel.Text = nativeCell.Description;
			}
			else if (e.PropertyName == SurveyCell.ImageFilenameProperty.PropertyName)
			{
				cell.ImageView.Image = cell.GetImage(nativeCell.ImageFilename);
			}
		}

	}

}
