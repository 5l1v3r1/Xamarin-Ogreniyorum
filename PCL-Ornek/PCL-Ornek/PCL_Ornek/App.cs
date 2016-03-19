using PCL_Ornek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PCL_Ornek
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var startPage = new Start();
            var detailPage = new MainPage();
            var masterPage = new MenuPage();

            startPage.Detail = detailPage;
            startPage.Master = masterPage;

            MainPage = startPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
