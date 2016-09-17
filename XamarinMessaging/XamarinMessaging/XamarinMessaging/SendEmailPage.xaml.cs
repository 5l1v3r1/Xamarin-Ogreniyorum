using Plugin.Messaging;
using Xamarin.Forms;

namespace XamarinMessaging
{
    public partial class SendEmailPage : ContentPage
    {
        public SendEmailPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.FromRgba(0, 0, 0, 0.8);

            Button btnSendEmail = new Button
            {
                Text = "Send Email"
            };
            btnSendEmail.Clicked += BtnSendEmail_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    btnSendEmail
                }
            };
        }

        private void BtnSendEmail_Clicked(object sender, System.EventArgs e)
        {
            var sendEmail = CrossMessaging.Current.EmailMessenger;
            if (sendEmail.CanSendEmail)
            {
                if (Device.OS == TargetPlatform.Android ||
                    Device.OS == TargetPlatform.iOS)
                {
                    if (sendEmail.CanSendEmailBodyAsHtml && 
                        sendEmail.CanSendEmailAttachments)
                    {
                        var emailWithHtmlBody = new EmailMessageBuilder()
                        .To("ozaksuty@gmail.com")
                        .Cc("yigit.ozaksut@xamarintr.com")
                        .Bcc("info@xamarintr.com")
                        .Subject("Xamarin Messaging Plugin")
                        .BodyAsHtml("<b>Yiğit Özaksüt</b> http://www.ozaksut.com")
                        .WithAttachment("http://www.xamarintr.com/Portals/0/Images/logo-xamarintr.png", "http://www.xamarintr.com/Portals/0/Images/logo-xamarintr.png")
                        .Build();
                        sendEmail.SendEmail(emailWithHtmlBody);
                    }
                }
                else
                {
                    var email = new EmailMessageBuilder()
                    .To("ozaksuty@gmail.com")
                    .Cc("yigit.ozaksut@xamarintr.com")
                    .Bcc("info@xamarintr.com")
                    .Subject("Xamarin Messaging Plugin")
                    .Body("Xamarin Messaging Plugin Test Mail")
                    .Build();
                    sendEmail.SendEmail(email);
                }
            }
        }
    }
}