using ImageCircle.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;

namespace XamarinCircleImage
{
    public class App : Application
    {
        public App()
        {
            var content = new ContentPage
            {
                Title = "XamarinCircleImage",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        new CircleImage
                        {
                          BorderColor = Color.Red,
                          BorderThickness = 5,
                          HeightRequest = 150,
                          WidthRequest = 150,
                          Aspect = Aspect.AspectFill,
                          HorizontalOptions = LayoutOptions.Center,
                          Source = UriImageSource.FromUri(new Uri("http://www.xamarintr.com/Portals/0/Users/003/03/3/yigit-ozaksut.jpg"))
                        }
                    }
                }
            };

            //MainPage = new NavigationPage(content);
            MainPage = new CircleSample();
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
