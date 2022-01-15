using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentLeft), typeof(clsButtonTextAlignmentLeftAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class clsButtonTextAlignmentLeftAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
        }
        public clsButtonTextAlignmentLeftAndroid(Context context) : base(context)
        {
        }
    }
}