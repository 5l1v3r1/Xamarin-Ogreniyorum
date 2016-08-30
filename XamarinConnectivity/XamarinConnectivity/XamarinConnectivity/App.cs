using Plugin.Connectivity;
using Xamarin.Forms;

namespace XamarinConnectivity
{
    public class App : Application
    {
        public App()
        {
            Button btnCheckConnection = new Button
            {
                Text = "Check Internet Connection"
            };

            Label lblConnectionStatus = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35
            };

            Label lblBandwidths = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35
            };

            Label lblConnectionType = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35
            };

            Label lblIsReachable = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35
            };

            Label lblIsReachable2 = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35
            };

            btnCheckConnection.Clicked += async (s, e) =>
            {
                lblBandwidths.Text = "";
                lblConnectionType.Text = "";

                lblConnectionStatus.Text = CrossConnectivity.Current.IsConnected
                ? "Connected" : "No Connection";
                foreach (var item in CrossConnectivity.Current.Bandwidths)
                    lblBandwidths.Text += item.ToString();
                foreach (var item in CrossConnectivity.Current.ConnectionTypes)
                    lblConnectionType.Text += item.ToString();

                lblIsReachable.Text = await CrossConnectivity.Current.IsReachable("127.0.0.1") 
                ? "Reachable" : "Not reachable";

                lblIsReachable2.Text = await CrossConnectivity.Current.IsRemoteReachable("ozaksut.com", 80)
                ? "Reachable" : "Not reachable";
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        btnCheckConnection,
                        lblConnectionStatus,
                        lblBandwidths,
                        lblConnectionType,
                        lblIsReachable,
                        lblIsReachable2
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
