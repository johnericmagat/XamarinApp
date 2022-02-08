using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(ButtonTextAlignmentCenter), typeof(ButtonTextAlignmentCenterAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class ButtonTextAlignmentCenterAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.Center;
        }
        public ButtonTextAlignmentCenterAndroid(Context context) : base(context)
        {
        }
    }
}