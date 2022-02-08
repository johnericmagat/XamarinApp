using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SysLoginPage : ContentPage
	{
		public SysLoginPage()
		{
			InitializeComponent();
		}

		[Obsolete]
		private void BtnLogin_Tapped(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new SysMasterDetailPage());
		}

		private void BtnSignUp_Tapped(object sender, EventArgs e)
		{

		}
	}
}
