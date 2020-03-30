using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CommandSample
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel() => AddCommand = new Xamarin.Forms.Command(OnAddCommandExecuted);

        public ICommand AddCommand { get; }

        private int number;

        public int Number
        {
            get => number;
            set
            {
                if (value != number)
                {
                    number = value;
                    NotifyPropertyChanged(nameof(Number));
                }
            }
        }

        private void OnAddCommandExecuted() => Number++;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
