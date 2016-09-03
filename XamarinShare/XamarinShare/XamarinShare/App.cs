using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace XamarinShare
{
    public class App : Application
    {
        public App()
        {
            Entry txtMessageText = new Entry
            {
                Placeholder = "Message Text"
            };
            Entry txtShareText = new Entry
            {
                Placeholder = "Share Text"
            };

            Button btnShare = new Button
            {
                Text = "Share"
            };
            
            btnShare.Clicked += async (s, e) =>
            {
                await CrossShare.Current.Share(
                    txtShareText.Text, "Share!");
            };

            Button btnShareLink = new Button
            {
                Text = "Share Link"
            };

            btnShareLink.Clicked += async (s, e) =>
            {
                await CrossShare.Current.ShareLink(
                    "https://www.acikakademi.com", txtMessageText.Text,
                    txtShareText.Text);
            };

            Button btnOpenBrowser = new Button
            {
                Text = "Open Browser"
            };

            btnOpenBrowser.Clicked += async (s, e) =>
            {
                await CrossShare.Current.OpenBrowser(
                    "https://www.acikakademi.com", new BrowserOptions
                    {
                        ChromeShowTitle = true,
                        UseSafairReaderMode = true,
                        UseSafariWebViewController = true
                    });
            };

            Button btnSetClipboard = new Button
            {
                Text = "Set Clipboard"
            };

            btnSetClipboard.Clicked += async (s, e) =>
            {
                await CrossShare.Current.SetClipboardText(
                    txtMessageText.Text, txtShareText.Text);
            };

            MainPage = new ContentPage
            {
                Padding = Device.OnPlatform(20, 0, 0),
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        txtShareText,
                        txtMessageText,
                        btnShare,
                        btnShareLink,
                        btnOpenBrowser,
                        btnSetClipboard
                    }
                }
            };
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
