using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(clsCustomViewCell), typeof(clsCustomViewCelliOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class clsCustomViewCelliOS : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);
			var view = item as clsCustomViewCell;
			cell.SelectedBackgroundView = new UIView
			{
				BackgroundColor = view.SelectedItemBackgroundColor.ToUIColor(),
			};

			return cell;
		}
	}
}