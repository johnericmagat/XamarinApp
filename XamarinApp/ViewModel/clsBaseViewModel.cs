using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinApp.ViewModel
{
	public class clsBaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
