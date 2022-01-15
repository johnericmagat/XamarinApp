using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp.Helper
{
	public static class clsStackLayoutButtonHelper
	{
		public static void ButtonTappedBackground(ContentPage contentPage)
		{
			StackLayout stackLayoutButton = contentPage.FindByName<StackLayout>("StackLayoutButton");
			stackLayoutButton.GestureRecognizers.Add(
			new TapGestureRecognizer()
			{
				Command = new Command(async () =>
				{
					stackLayoutButton.BackgroundColor = Color.FromHex("#CCCCCC");

					await Task.Run(async () => {
						await Task.Delay(100);
						Device.BeginInvokeOnMainThread(() => {
							stackLayoutButton.BackgroundColor = Color.LightGreen;
						});
					});
				})
			});
		}
	}
}
