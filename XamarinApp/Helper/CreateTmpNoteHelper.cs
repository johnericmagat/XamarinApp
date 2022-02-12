using Xamarin.Forms;
using XamarinApp.Model;

namespace XamarinApp.Helper
{
	public class CreateTmpNoteHelper
	{
		public void CreateTable()
		{
			using (var connection = DependencyService.Get<SQLiteInterface>().GetConnection())
			{
				connection.CreateTable<TrnNoteModel>();
			}
		}
	}
}
