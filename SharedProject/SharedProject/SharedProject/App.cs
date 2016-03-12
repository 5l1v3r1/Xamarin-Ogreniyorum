using SharedProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SharedProject
{
	public class App : Application
	{
		public App ()
		{
            var applicationMainPage = new Start();
            var masterPage = new Menu();
            var detailPage = new Detail();

            applicationMainPage.Master = masterPage;
            applicationMainPage.Detail = detailPage;

            MainPage = applicationMainPage;
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
