﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;
using XamarinApp.ViewModel;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrnNoteDetailPage : ContentPage
	{
		clsNoteDetailViewModel vm;
		public TrnNoteDetailPage(clsNote note)
		{
			InitializeComponent();

			vm = new clsNoteDetailViewModel();
			BindingContext = vm;

			TxtId.Text = note.Id.ToString();
			TxtNote.Text = note.Note;
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
				TxtNote.Focus();
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