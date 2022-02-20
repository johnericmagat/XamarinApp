using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModel
{
	public class MstLabelsListViewModel : BaseViewModel
	{
		public ObservableCollection<MstLabelsModel> Labels { get; set; }

		private MstLabelsModel previousLabel;

		public MstLabelsModel Label;

		public Command ViewLabelCommand { get; set; }
		public Command DeleteLabelCommand { get; set; }
		public Command FilterLabelCommand { get; set; }

		public MstLabelsListViewModel()
		{
			Labels = new ObservableCollection<MstLabelsModel>();

			ViewLabelCommand = new Command<int>(async (id) => await ViewLabel(id));
			DeleteLabelCommand = new Command<int>((id) => DeleteLabel(id));
			FilterLabelCommand = new Command(() => FilterLabel());
		}

		private async Task<MstLabelsModel> ViewLabel(int id)
		{
			Label = new MstLabelsModel();

			MstLabelsService labelsService = new MstLabelsService();
			Label = await labelsService.ViewLabel(id);

			return Label;
		}

		private void DeleteLabel(int id)
		{
			MstLabelsService labelsService = new MstLabelsService();
			labelsService.DeleteLabel(id);
		}

		private async void FilterLabel()
		{
			Labels.Clear();

			MstLabelsService labelService = new MstLabelsService();
			var query = await labelService.FilterLabels();

			foreach (var label in query)
			{
				Labels.Add(label);
			}
		}

		public void ShowOrHideLables(MstLabelsModel label)
		{
			if (previousLabel == label)
			{
				// click twice on the same item will hide it
				label.IsVisible = !label.IsVisible;
				UpdateLabels(label);
			}
			else
			{
				if (previousLabel != null)
				{
					// hide previous selected item
					previousLabel.IsVisible = false;
					UpdateLabels(previousLabel);
				}

				// show selected item
				label.IsVisible = true;
				UpdateLabels(label);
			}

			previousLabel = label;
		}

		private void UpdateLabels(MstLabelsModel label)
		{
			int index = Labels.IndexOf(label);

			if (index >= 0)
			{
				Labels.Remove(label);
				Labels.Insert(index, label);
			}
		}
	}
}
