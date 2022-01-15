using Xamarin.Forms;

namespace XamarinApp.CustomRenderer
{
	public class clsCustomViewCell : ViewCell
	{
		public static readonly BindableProperty SelectedItemBackgroundColorProperty =
			BindableProperty.Create("SelectedItemBackgroundColor", typeof(Color), typeof(clsCustomViewCell), Color.Default);

		public Color SelectedItemBackgroundColor
		{
			get { return (Color)GetValue(SelectedItemBackgroundColorProperty); }
			set { SetValue(SelectedItemBackgroundColorProperty, value); }
		}
	}
}
