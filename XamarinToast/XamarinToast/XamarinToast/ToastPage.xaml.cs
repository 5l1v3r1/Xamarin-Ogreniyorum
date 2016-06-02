using Plugin.Toasts;
using System;
using Xamarin.Forms;

namespace XamarinToast
{
    public partial class ToastPage : ContentPage
    {
        IToastNotificator notificator;
        public ToastPage ()
		{
			InitializeComponent ();
            notificator = DependencyService.Get<IToastNotificator>();
        }

        private async void onInfo(object sender, EventArgs e)
        {
            await notificator.Notify(ToastNotificationType.Info, "Info", "Info Description", TimeSpan.FromSeconds(2));
        }

        private async void onSuccess(object sender, EventArgs e)
        {
            await notificator.Notify(ToastNotificationType.Success, "Success", "Success Description", TimeSpan.FromSeconds(2));
        }

        private async void onWarning(object sender, EventArgs e)
        {
            await notificator.Notify(ToastNotificationType.Warning, "Warning", "Warning Description", TimeSpan.FromSeconds(2));
        }

        private async void onError(object sender, EventArgs e)
        {
            await notificator.Notify(ToastNotificationType.Error, "Error", "Error Description", TimeSpan.FromSeconds(2));
        }
    }
}
