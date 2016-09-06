using Plugin.LocalNotifications;
using System;
using Xamarin.Forms;

namespace XamarinLocalPush.Views
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void OnInsert(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            CrossLocalNotifications.Current.Show("Xamarin Türkiye",
                name + " " + surname, 1, DateTime.Now.AddSeconds(30));

            CrossLocalNotifications.Current.Show("Xamarin Türkiye",
                "www.xamarintr.com", 2, DateTime.Now.AddSeconds(30));

            CrossLocalNotifications.Current.Cancel(2);
        }
    }
}