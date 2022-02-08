using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using XamarinApp.Model;

[assembly: Dependency(typeof(XamarinApp.iOS.SQLite_iOS))]
namespace XamarinApp.iOS
{
	public class SQLite_iOS : SQLiteInterface
	{
		public SQLiteConnection GetConnection()
		{
			var sQLiteFileName = "local.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, sQLiteFileName);
			var connection = new SQLiteConnection(path);
			return connection;
		}
	}
}