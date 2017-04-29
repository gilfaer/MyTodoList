using Windows.UI.Xaml.Controls;
using MyToDoList.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyToDoList.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new MainPageViewModel
            {
                User = new UserViewModel
                {
                    FirstName = "Michael",
                    LastName = "Olson"
                }
            };
        }

        public MainPageViewModel ViewModel => DataContext as MainPageViewModel;
    }
}
