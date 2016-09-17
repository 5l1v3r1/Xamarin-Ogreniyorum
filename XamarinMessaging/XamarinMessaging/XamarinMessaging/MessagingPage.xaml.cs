using Xamarin.Forms;

namespace XamarinMessaging
{
    public partial class MessagingPage : ContentPage
    {
        public MessagingPage()
        {
            InitializeComponent();
            this.Title = "Messaging Plugin";
            this.BackgroundColor = Color.FromRgba(0, 0, 0, 0.8);
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0),
                0, 0);

            Button btnMakePhoneCall = new Button
            {
                Text = "Make Phone Call"
            };
            btnMakePhoneCall.Clicked += (o, s) =>
            {
                this.Navigation.PushAsync(new PhoneCallPage());
            };

            Button btnSendSms = new Button
            {
                Text = "Send SMS"
            };
            btnSendSms.Clicked += (o, s) =>
            {
                this.Navigation.PushAsync(new SendSmsPage());
            };

            Button btnSendEmail = new Button
            {
                Text = "Send Email"
            };
            btnSendEmail.Clicked += (o, s) =>
            {
                this.Navigation.PushAsync(new SendEmailPage());
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, 10, 0, 0),
                Children =
                {
                    btnMakePhoneCall,
                    btnSendSms,
                    btnSendEmail
                }
            };
        }
    }
}
