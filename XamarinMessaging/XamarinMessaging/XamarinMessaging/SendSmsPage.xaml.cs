using Plugin.Messaging;
using System;
using Xamarin.Forms;

namespace XamarinMessaging
{
    public partial class SendSmsPage : ContentPage
    {
        public SendSmsPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.FromRgba(0, 0, 0, 0.8);
        }

        private void SendSms(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string message = txtMessage.Text;

            if (!String.IsNullOrEmpty(phoneNumber) &&
                !String.IsNullOrEmpty(message))
            {
                var sendSms = CrossMessaging.Current.SmsMessenger;
                if (sendSms.CanSendSms)
                {
                    sendSms.SendSms(phoneNumber, message);
                }
            }
        }
    }
}