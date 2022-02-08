using SQLite;

namespace XamarinApp.Model
{
	public interface SQLiteInterface
	{
		SQLiteConnection GetConnection();
	}
}
