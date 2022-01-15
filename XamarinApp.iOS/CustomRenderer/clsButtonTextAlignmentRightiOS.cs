using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinApp.CustomRenderer;
using XamarinApp.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentRight), typeof(clsButtonTextAlignmentRightiOS))]
namespace XamarinApp.iOS.CustomRenderer
{
	public class clsButtonTextAlignmentRightiOS : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				//Control.TitleLabel.TextAlignment = UITextAlignment.Right | UITextAlignment.Center;

				Control.HorizontalAlignment = UIControlContentHorizontalAlignment.Right | UIControlContentHorizontalAlignment.Center;
			}
		}
	}
}