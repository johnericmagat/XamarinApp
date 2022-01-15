using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentCenter), typeof(clsButtonTextAlignmentCenteriOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class clsButtonTextAlignmentCenteriOS : ButtonRenderer
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