using System;
using Xamarin.Forms;

namespace XamarinResources
{
    public partial class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            InitializeComponent();
        }

        void OnLight(object sender, EventArgs e)
        {
            Resources["fgColor"] = Color.FromHex("#606060");
            Resources["bgColor"] = Color.FromHex("#c0c0c0");
        }

        void OnDark(object sender, EventArgs e)
        {
            Resources["fgColor"] = Color.FromHex("#c0c0c0");
            Resources["bgColor"] = Color.FromHex("#606060");
        }
    }
}