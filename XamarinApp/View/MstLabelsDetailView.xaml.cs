using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;
using XamarinApp.ViewModel;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MstLabelsDetailView : ContentPage
	{
		MstLabelsDetailViewModel vm;

		public MstLabelsDetailView(MstLabelsModel label)
		{
			InitializeComponent();

			vm = new MstLabelsDetailViewModel();
			BindingContext = vm;

			vm.Id = label.Id;
			vm.Code = label.Code;
			vm.Label = label.Label;
			vm.DisplayedLabel = label.DisplayedLabel;
			vm.IsVisible = label.IsVisible;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (vm.Id > 0)
			{
				BtnUpdateFrame.IsVisible = true;
			}
			else
			{
				BtnSaveFrame.IsVisible = true;
				TxtCode.Focus();
			}
		}

		private void BtnSave_Tapped(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private void BtnUpdate_Tapped(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private void BtnClose_Tapped(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}