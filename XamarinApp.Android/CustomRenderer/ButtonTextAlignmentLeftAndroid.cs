using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(ButtonTextAlignmentLeft), typeof(ButtonTextAlignmentLeftAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class ButtonTextAlignmentLeftAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
        }
        public ButtonTextAlignmentLeftAndroid(Context context) : base(context)
        {
        }
    }
}