using Plugin.Messaging;
using System;
using Xamarin.Forms;

namespace XamarinMessaging
{
    public partial class PhoneCallPage : ContentPage
    {
        public PhoneCallPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.FromRgba(0, 0, 0, 0.8);
        }

        private void Call(object sender, EventArgs e)
        {
            IPhoneCallTask phoneCall = CrossMessaging.Current.PhoneDialer;
            if (phoneCall.CanMakePhoneCall &&
                !String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                phoneCall.MakePhoneCall(txtPhoneNumber.Text);
            }
        }
    }
}