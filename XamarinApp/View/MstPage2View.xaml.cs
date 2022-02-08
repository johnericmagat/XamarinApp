using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MstPage2View : ContentPage
	{
		public MstPage2View()
		{
			InitializeComponent();
		}

		private void BtnClose_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}