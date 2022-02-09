using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinApp.Model;

namespace XamarinApp.Service
{
	public class TrnNoteService
	{
		public void InsertNote(TrnNoteModel note)
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				connection.Execute("INSERT INTO TmpNote(Note) VALUES(?)", note.Note);
				connection.Close();
				connection.Dispose();
			}
		}

		public void UpdateNote(TrnNoteModel note)
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				connection.Execute("UPDATE TmpNote SET Note = ? WHERE Id = ?", note.Note, note.Id);
				connection.Close();
				connection.Dispose();
			}
		}

		public TrnNoteModel ViewNote(int id)
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				var notes = connection.Query<TrnNoteModel>("SELECT * FROM TmpNote WHERE Id = ?", id);
				connection.Close();
				connection.Dispose();

				TrnNoteModel note = new TrnNoteModel();
				note.Id = notes[0].Id;
				note.Note = notes[0].Note;
				return note;
			}
		}

		public void DeleteNote(int id)
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				connection.Execute("DELETE FROM TmpNote WHERE Id = ?", id);
				connection.Close();
				connection.Dispose();
			}
		}

		public ObservableCollection<TrnNoteModel> FilterNote(string search)
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				var notes = connection.Query<TrnNoteModel>("SELECT * FROM TmpNote WHERE Note LIKE (SELECT '%' || ? || '%')", search);
				connection.Close();
				connection.Dispose();
				return new ObservableCollection<TrnNoteModel>(notes);
			}
		}
	}
}
