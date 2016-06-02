using Plugin.Toasts;

namespace XamarinToast.Windows
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Xamarin.Forms.DependencyService.Register<ToastNotificatorImplementation>();
            ToastNotificatorImplementation.Init();

            LoadApplication(new XamarinToast.App());
        }
    }
}
