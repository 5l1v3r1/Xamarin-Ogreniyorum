using Xamarin.Forms;

namespace XamarinCarouselView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MyCarouselView();
        }
    }
}