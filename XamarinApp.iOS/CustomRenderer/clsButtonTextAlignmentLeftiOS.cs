using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentLeft), typeof(clsButtonTextAlignmentLeftiOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class clsButtonTextAlignmentLeftiOS : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				//Control.TitleLabel.TextAlignment = UITextAlignment.Left | UITextAlignment.Center;

				Control.HorizontalAlignment = UIControlContentHorizontalAlignment.Left | UIControlContentHorizontalAlignment.Center;
			}
		}
	}
}