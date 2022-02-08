using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCelliOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class CustomViewCelliOS : ViewCellRenderer
	{
		public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			var cell = base.GetCell(item, reusableCell, tv);
			var view = item as CustomViewCell;
			cell.SelectedBackgroundView = new UIView
			{
				BackgroundColor = view.SelectedItemBackgroundColor.ToUIColor(),
			};

			return cell;
		}
	}
}