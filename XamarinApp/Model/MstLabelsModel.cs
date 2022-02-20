using System;

namespace XamarinApp.Model
{
	public class MstLabelsModel
	{
		public Int32 Id { get; set; }
		public String Code { get; set; }
		public String Label { get; set; }
		public String DisplayedLabel { get; set; }
		public bool IsVisible { get; set; }
	}
}
