using System;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class TrnNoteDetailViewModel : BaseViewModel
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

		public TrnNoteDetailViewModel()
		{
			InsertNoteCommand = new Command(() => InsertNote());
			UpdateNoteCommand = new Command(() => UpdateNote());
		}

		private void InsertNote()
		{
			try
			{
				TrnNoteModel note = new TrnNoteModel();
				note.Note = Note;

				TrnNoteService noteService = new TrnNoteService();
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
				TrnNoteModel note = new TrnNoteModel();
				note.Id = Id;
				note.Note = Note;

				TrnNoteService noteService = new TrnNoteService();
				noteService.UpdateNote(note);
			}
			catch (Exception)
			{
			}
		}
	}
}
