using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CommandSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = (MainPageViewModel)BindingContext;
        }
    }
}
