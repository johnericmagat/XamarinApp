using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Service;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SysLoginView : ContentPage
	{
		public SysLoginView()
		{
			InitializeComponent();
		}

		private async void BtnLogin_Tapped(object sender, EventArgs e)
		{
			SysAccessTokenService accessTokenService = new SysAccessTokenService();
			int user = await accessTokenService.WriteAccessToken();

			if (user > 0)
			{
				await Navigation.PushModalAsync(new SysMasterDetailView());
			}
		}

		private void BtnSignUp_Tapped(object sender, EventArgs e)
		{

		}
	}
}
