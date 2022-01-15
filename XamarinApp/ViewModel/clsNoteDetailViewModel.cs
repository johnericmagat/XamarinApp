using System;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class clsNoteDetailViewModel : clsBaseViewModel
	{
		private int id;

		public int Id
		{
			get { return id; }
			set
			{
				id = value;
				OnPropertyChanged();
			}
		}

		private string note;

		public string Note
		{
			get { return note; }
			set
			{
				note = value;
				OnPropertyChanged();
			}
		}

		public Command InsertNoteCommand { get; set; }
		public Command UpdateNoteCommand { get; set; }

		public clsNoteDetailViewModel()
		{
			InsertNoteCommand = new Command(() => InsertNote());
			UpdateNoteCommand = new Command(() => UpdateNote());
		}

		private void InsertNote()
		{
			try
			{
				clsNote note = new clsNote();
				note.Note = Note;

				clsNoteService noteService = new clsNoteService();
				noteService.InsertNote(note);
			}
			catch (Exception)
			{
			}
		}

		private void UpdateNote()
		{
			try
			{
				clsNote note = new clsNote();
				note.Id = Id;
				note.Note = Note;

				clsNoteService noteService = new clsNoteService();
				noteService.UpdateNote(note);
			}
			catch (Exception)
			{
			}
		}
	}
}
