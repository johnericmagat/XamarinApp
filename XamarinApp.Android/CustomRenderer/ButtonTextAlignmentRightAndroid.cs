using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(ButtonTextAlignmentRight), typeof(ButtonTextAlignmentRightAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class ButtonTextAlignmentRightAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.End | GravityFlags.CenterVertical;
        }
        public ButtonTextAlignmentRightAndroid(Context context) : base(context)
        {
        }
    }
}