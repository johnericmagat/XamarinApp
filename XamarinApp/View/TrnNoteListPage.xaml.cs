using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;
using XamarinApp.ViewModel;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrnNoteListPage : ContentPage
	{
		clsNoteListViewModel vm;
		public TrnNoteListPage()
		{
			InitializeComponent();

			vm = new clsNoteListViewModel();
			BindingContext = vm;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			FilterNote();
		}

		private void FilterNote()
		{
			string search;
			if (TxtSearch.Text == null)
			{
				search = "";
			}
			else
			{
				search = TxtSearch.Text;
			}

			vm.FilterNoteCommand.Execute(search);
			LstNote.ItemsSource = vm.Notes;
		}

		private void BtnFilter_Clicked(object sender, EventArgs e)
		{
			FilterNote();
		}

		private void BtnView_Clicked(object sender, EventArgs e)
		{
			object id = ((ImageButton)sender).CommandParameter;
			vm.ViewNoteCommand.Execute(id);

			clsNote note = vm.Note;
			Navigation.PushAsync(new TrnNoteDetailPage(note));
		}

		private async void BtnDelete_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Confirm", "Delete record?", "Yes", "No");
			if (result)
			{
				object id = ((ImageButton)sender).CommandParameter;
				vm.DeleteNoteCommand.Execute(id);

				await DisplayAlert("Success", "Record deleted.", "Ok");
				FilterNote();
			}
		}

		private void BtnAdd_Tapped(object sender, EventArgs e)
		{
			clsNote note = new clsNote();
			Navigation.PushAsync(new TrnNoteDetailPage(note));
		}

		private void LstNote_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var note = e.Item as clsNote;
			vm = BindingContext as clsNoteListViewModel;
			vm?.ShowOrHidePoducts(note);
		}
	}
}
