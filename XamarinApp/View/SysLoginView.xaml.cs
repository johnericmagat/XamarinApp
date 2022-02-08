using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SysLoginView : ContentPage
	{
		public SysLoginView()
		{
			InitializeComponent();
		}

		[Obsolete]
		private void BtnLogin_Tapped(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new SysMasterDetailView());
		}

		private void BtnSignUp_Tapped(object sender, EventArgs e)
		{

		}
	}
}
