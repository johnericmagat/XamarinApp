using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinApp.Model;

namespace XamarinApp.Service
{
	public class clsNoteService
	{
		public void InsertNote(clsNote note)
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				connection.Execute("INSERT INTO TmpNote(Note) VALUES(?)", note.Note);
				connection.Close();
				connection.Dispose();
			}
		}

		public void UpdateNote(clsNote note)
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				connection.Execute("UPDATE TmpNote SET Note = ? WHERE Id = ?", note.Note, note.Id);
				connection.Close();
				connection.Dispose();
			}
		}

		public clsNote ViewNote(int id)
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				var notes = connection.Query<clsNote>("SELECT * FROM TmpNote WHERE Id = ?", id);
				connection.Close();
				connection.Dispose();

				clsNote note = new clsNote();
				note.Id = notes[0].Id;
				note.Note = notes[0].Note;
				return note;
			}
		}

		public void DeleteNote(int id)
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				connection.Execute("DELETE FROM TmpNote WHERE Id = ?", id);
				connection.Close();
				connection.Dispose();
			}
		}

		public ObservableCollection<clsNote> FilterNote(string search)
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				var notes = connection.Query<clsNote>("SELECT * FROM TmpNote WHERE Note LIKE (SELECT '%' || ? || '%')", search);
				connection.Close();
				connection.Dispose();
				return new ObservableCollection<clsNote>(notes);
			}
		}
	}
}
