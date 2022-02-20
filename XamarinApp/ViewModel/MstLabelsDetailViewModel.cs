using System;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class MstLabelsDetailViewModel : BaseViewModel
	{
		private int id;

		public int Id
		{
			get { return id; }
			set
			{
				id = value;
				OnPropertyChanged();
			}
		}

		private string code;

		public string Code
		{
			get { return code; }
			set
			{
				code = value;
				OnPropertyChanged();
			}
		}

		private string label;

		public string Label
		{
			get { return label; }
			set
			{
				label = value;
				OnPropertyChanged();
			}
		}

		private string displayedLabel;

		public string DisplayedLabel
		{
			get { return displayedLabel; }
			set
			{
				displayedLabel = value;
				OnPropertyChanged();
			}
		}

		private bool isVisible;

		public bool IsVisible
		{
			get { return isVisible; }
			set
			{
				isVisible = value;
				OnPropertyChanged();
			}
		}

		public Command InsertLabelCommand { get; set; }
		public Command UpdateLabelCommand { get; set; }

		public MstLabelsDetailViewModel()
		{
			InsertLabelCommand = new Command(() => InsertLabel());
			UpdateLabelCommand = new Command(() => UpdateLabel());
		}

		private void InsertLabel()
		{
			try
			{
				MstLabelsModel label = new MstLabelsModel();
				label.Id = Id;
				label.Code = Code;
				label.Label = Label;
				label.DisplayedLabel = DisplayedLabel;
				label.IsVisible = IsVisible;

				MstLabelsService labelsService = new MstLabelsService();
				labelsService.InsertLabel(label);
			}
			catch (Exception)
			{
			}
		}

		private void UpdateLabel()
		{
			try
			{
				MstLabelsModel label = new MstLabelsModel();
				label.Id = Id;
				label.Code = Code;
				label.Label = Label;
				label.DisplayedLabel = DisplayedLabel;
				label.IsVisible = IsVisible;

				MstLabelsService labelsService = new MstLabelsService();
				labelsService.UpdateLabel(Id, label);
			}
			catch (Exception)
			{
			}
		}
	}
}
