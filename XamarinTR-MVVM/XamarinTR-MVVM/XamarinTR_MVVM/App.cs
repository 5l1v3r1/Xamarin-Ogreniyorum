using Xamarin.Forms;
using XamarinTR_MVVM.Views;

namespace XamarinTR_MVVM
{
    public class App : Application
	{
		public App ()
		{
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
