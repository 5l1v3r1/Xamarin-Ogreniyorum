using Xamarin.Forms;
using XamarinConverters.Views;

namespace XamarinConverters
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ListPage();
        }
    }
}