using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinTRMenu.Views;

namespace XamarinTRMenu
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var mainPage = new Startup();
            var detailPage = new Detail();
            var menuPage = new Menu();

            mainPage.Master = menuPage;
            mainPage.Detail = detailPage;

            MainPage = mainPage;
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
