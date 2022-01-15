using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinApp.Helper;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class clsNoteListViewModel : clsBaseViewModel
	{
		private ObservableCollection<clsNote> notes;

		public ObservableCollection<clsNote> Notes
		{
			get { return notes; }
			set
			{
				notes = value;
			}
		}

		public Command CreateTableCommand { get; set; }
		public Command ViewNoteCommand { get; set; }
		public Command DeleteNoteCommand { get; set; }
		public Command FilterNoteCommand { get; set; }

		private clsNote previousNote;

		public clsNote Note;

		public clsNoteListViewModel()
		{
			Notes = new ObservableCollection<clsNote>();

			CreateTableCommand = new Command(() => CreateTable());
			ViewNoteCommand = new Command<int>((id) => ViewNote(id));
			DeleteNoteCommand = new Command<int>((id) => DeleteNote(id));
			FilterNoteCommand = new Command<string>((search) => FilterNote(search));

			CreateTableCommand.Execute(null);
		}

		private void CreateTable()
		{
			var createTmpNoteHelper = new clsCreateTmpNoteHelper();
			createTmpNoteHelper.CreateTable();
		}

		private clsNote ViewNote(int id)
		{
			Note = new clsNote();

			clsNoteService noteService = new clsNoteService();
			Note = noteService.ViewNote(id);

			return Note;
		}

		private void DeleteNote(int id)
		{
			clsNoteService noteService = new clsNoteService();
			noteService.DeleteNote(id);
		}

		private void FilterNote(string search)
		{
			Notes = new ObservableCollection<clsNote>();

			clsNoteService noteService = new clsNoteService();
			var query = noteService.FilterNote(search);

			foreach (var note in query)
			{
				Notes.Add(note);
			}
		}

		public void ShowOrHidePoducts(clsNote note)
		{
			if (previousNote == note)
			{
				// click twice on the same item will hide it
				note.IsVisible = !note.IsVisible;
				UpdateNotes(note);
			}
			else
			{
				if (previousNote != null)
				{
					// hide previous selected item
					previousNote.IsVisible = false;
					UpdateNotes(previousNote);
				}
				// show selected item
				note.IsVisible = true;
				UpdateNotes(note);
			}

			previousNote = note;
		}

		private void UpdateNotes(clsNote note)
		{
			var index = Notes.IndexOf(note);

			if (index >= 0)
			{
				Notes.Remove(note);
				Notes.Insert(index, note);
			}
		}
	}
}
