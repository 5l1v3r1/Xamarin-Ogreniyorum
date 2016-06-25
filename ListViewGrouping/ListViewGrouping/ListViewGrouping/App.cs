using ListViewGrouping.Views;
using Xamarin.Forms;

namespace ListViewGrouping
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Players());
        }
    }
}