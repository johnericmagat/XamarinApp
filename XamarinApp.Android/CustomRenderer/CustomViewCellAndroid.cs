using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class CustomViewCellAndroid : ViewCellRenderer
	{
		private Android.Views.View _cellCore;
		private Drawable _unselectedBackground;
		private bool _selected;

		protected override Android.Views.View GetCellCore(Cell item,
			Android.Views.View convertView, ViewGroup parent, Context context)
		{
			_cellCore = base.GetCellCore(item, convertView, parent, context);

			_selected = false;
			_unselectedBackground = _cellCore.Background;

			return _cellCore;
		}

		protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
		{
			base.OnCellPropertyChanged(sender, args);

			if (args.PropertyName == "IsSelected")
			{
				_selected = !_selected;

				if (_selected)
				{
					var extendedCellView = sender as CustomViewCell;
					_cellCore.SetBackgroundColor(extendedCellView.SelectedItemBackgroundColor.ToAndroid());
				}
				else
				{
					_cellCore.SetBackground(_unselectedBackground);
				}
			}
		}
	}
}