using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;
using XamarinApp.ViewModel;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MstLabelsListView : ContentPage
	{
		MstLabelsListViewModel vm;
		public MstLabelsListView()
		{
			InitializeComponent();

			vm = new MstLabelsListViewModel();
			BindingContext = vm;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			FilterLabels();
		}

		private void FilterLabels()
		{
			vm.FilterLabelCommand.Execute(null);
			LstLabels.ItemsSource = vm.Labels;
		}

		private void BtnFilter_Clicked(object sender, EventArgs e)
		{
			FilterLabels();
		}

		private void BtnView_Clicked(object sender, EventArgs e)
		{
			ImageButton button = sender as ImageButton;
			var context = button.BindingContext as MstLabelsModel;

			Navigation.PushAsync(new MstLabelsDetailView(context));
		}

		private async void BtnDelete_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Confirm", "Delete record?", "Yes", "No");
			if (result)
			{
				object id = ((ImageButton)sender).CommandParameter;
				vm.DeleteLabelCommand.Execute(id);

				await DisplayAlert("Success", "Record deleted.", "Ok");
				FilterLabels();
			}
		}

		private void BtnAdd_Tapped(object sender, EventArgs e)
		{
			MstLabelsModel labelsModel = new MstLabelsModel();
			Navigation.PushAsync(new MstLabelsDetailView(labelsModel));
		}

		private void LstLabels_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var label = e.Item as MstLabelsModel;
			vm = BindingContext as MstLabelsListViewModel;
			vm?.ShowOrHideLables(label);
		}
	}
}
