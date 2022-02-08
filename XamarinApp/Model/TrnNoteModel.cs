using SQLite;

namespace XamarinApp.Model
{
	[Table("TmpNote")]
	public class TrnNoteModel
	{
		[Column("Id"), PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		[Column("Note"), MaxLength(100)]
		public string Note { get; set; }
		[Ignore]
		public bool IsVisible { get; set; }
	}
}
