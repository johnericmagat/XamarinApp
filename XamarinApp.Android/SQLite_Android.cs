using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using XamarinApp.Model;

[assembly: Dependency(typeof(XamarinApp.Droid.SQLite_Android))]
namespace XamarinApp.Droid
{
	public class SQLite_Android : SQLiteInterface
	{
		public SQLiteConnection GetConnection()
		{
			var sQLiteFileName = "local.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, sQLiteFileName);
			var connection = new SQLiteConnection(path);
			return connection;
		}
	}
}