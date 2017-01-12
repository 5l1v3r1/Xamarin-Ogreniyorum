using System;
using Xamarin.Forms;

namespace HockeyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.Title = "Xamarin.Forms - HockeyApp";
            InitializeComponent();
        }

        private void onBoom(object sender, EventArgs e)
        {
            throw new Exception(); //BOOM! Crash App
        }
    }
}