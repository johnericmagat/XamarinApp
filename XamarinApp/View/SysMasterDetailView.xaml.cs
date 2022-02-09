using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SysMasterDetailView : MasterDetailPage
	{
		public SysMasterDetailView()
		{
			InitializeComponent();

			Detail = new NavigationPage(new MstPage1View());
			IsPresented = false;
		}

		private void BtnMasterFile_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnTransaction_Clicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new TrnNoteListView());
			IsPresented = false;
		}

		private void BtnReport_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnSetting_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnUtilities_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnAboutUs_Clicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new MstPage1View());
			IsPresented = false;
		}

		private void BtnLogout_Clicked(object sender, EventArgs e)
		{

		}
	}
}
