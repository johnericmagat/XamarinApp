using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinApp.Helper;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class TrnNoteListViewModel : BaseViewModel
	{
		private ObservableCollection<TrnNoteModel> notes;

		public ObservableCollection<TrnNoteModel> Notes
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

		private TrnNoteModel previousNote;

		public TrnNoteModel Note;

		public TrnNoteListViewModel()
		{
			Notes = new ObservableCollection<TrnNoteModel>();

			CreateTableCommand = new Command(() => CreateTable());
			ViewNoteCommand = new Command<int>((id) => ViewNote(id));
			DeleteNoteCommand = new Command<int>((id) => DeleteNote(id));
			FilterNoteCommand = new Command<string>((search) => FilterNote(search));

			CreateTableCommand.Execute(null);
		}

		private void CreateTable()
		{
			var createTmpNoteHelper = new CreateTmpNoteHelper();
			createTmpNoteHelper.CreateTable();
		}

		private TrnNoteModel ViewNote(int id)
		{
			Note = new TrnNoteModel();

			TrnNoteService noteService = new TrnNoteService();
			Note = noteService.ViewNote(id);

			return Note;
		}

		private void DeleteNote(int id)
		{
			TrnNoteService noteService = new TrnNoteService();
			noteService.DeleteNote(id);
		}

		private void FilterNote(string search)
		{
			Notes = new ObservableCollection<TrnNoteModel>();

			TrnNoteService noteService = new TrnNoteService();
			var query = noteService.FilterNote(search);

			foreach (var note in query)
			{
				Notes.Add(note);
			}
		}

		public void ShowOrHidePoducts(TrnNoteModel note)
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

		private void UpdateNotes(TrnNoteModel note)
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
