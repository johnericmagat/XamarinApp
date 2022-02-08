using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(ButtonTextAlignmentCenter), typeof(ButtonTextAlignmentCenteriOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class ButtonTextAlignmentCenteriOS : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				//Control.TitleLabel.TextAlignment = UITextAlignment.Center;

				Control.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			}
		}
	}
}