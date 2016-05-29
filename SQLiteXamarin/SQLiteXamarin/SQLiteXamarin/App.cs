using SQLiteXamarin.Views;
using Xamarin.Forms;

namespace SQLiteXamarin
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var masterPage = new Start();
            masterPage.Detail = new List();
            masterPage.Master = new Menu();

            MainPage = masterPage;
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
