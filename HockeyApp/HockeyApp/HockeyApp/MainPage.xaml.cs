using System;
using System.Collections.Generic;
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

        private void onTrack(object sender, EventArgs e)
        {
            MetricsManager.TrackEvent(
            "onTrack Event",
               new Dictionary<string, string> {
                   { "time", DateTime.UtcNow.ToString() } },
               new Dictionary<string, double> {
                   { "value", 1.0 } }
            );
        }
    }
}