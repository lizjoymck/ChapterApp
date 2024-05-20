using ChapterApp.ViewModel;

namespace ChapterApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm; // Associates the ViewModel with the main page
        }
    }

}
