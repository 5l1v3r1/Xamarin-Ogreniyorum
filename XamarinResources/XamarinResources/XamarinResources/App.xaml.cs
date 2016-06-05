using Xamarin.Forms;

namespace XamarinResources
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MyContentPage());
        }
    }
}