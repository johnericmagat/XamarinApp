using Xamarin.Forms;
using XamarinApp.View;

namespace XamarinApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new SysLoginView();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
