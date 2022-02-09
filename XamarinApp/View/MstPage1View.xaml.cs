using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MstPage1View : ContentPage
	{
		public MstPage1View()
		{
			InitializeComponent();
		}

		private void BtnView_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MstPage2View());
		}
	}
}