using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.CustomRenderer;
using XamarinApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(clsButtonTextAlignmentRight), typeof(clsButtonTextAlignmentRightAndroid))]
namespace XamarinApp.Droid.CustomRenderer
{
	public class clsButtonTextAlignmentRightAndroid : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.Gravity = GravityFlags.End | GravityFlags.CenterVertical;
        }
        public clsButtonTextAlignmentRightAndroid(Context context) : base(context)
        {
        }
    }
}