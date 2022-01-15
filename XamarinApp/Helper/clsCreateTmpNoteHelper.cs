using System;
using Xamarin.Forms;
using XamarinApp.Model;

namespace XamarinApp.Helper
{
	public class clsCreateTmpNoteHelper
	{
		public void CreateTable()
		{
			using (var connection = DependencyService.Get<clsSQLiteInterface>().GetConnection())
			{
				connection.CreateTable<clsNote>();
				connection.Close();
				connection.Dispose();
			}
		}
	}
}
