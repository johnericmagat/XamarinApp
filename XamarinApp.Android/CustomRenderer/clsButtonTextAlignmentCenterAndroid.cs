using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentCenter), typeof(clsButtonTextAlignmentCenterAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class clsButtonTextAlignmentCenterAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.Center;
        }
        public clsButtonTextAlignmentCenterAndroid(Context context) : base(context)
        {
        }
    }
}