using Xamarin.Forms;

namespace XamarinDisplayAction
{
    public partial class DisplayPage : ContentPage
    {
        public DisplayPage()
        {
            InitializeComponent();

            Button btnDisplayAction = new Button
            {
                Text = "Options",
                HorizontalOptions = LayoutOptions.Center
            };

            string[] colors = { "red", "blue", "black", "white", "yellow" };
            btnDisplayAction.Clicked += async (o, s) =>
            {
                string selectedColor = await DisplayActionSheet(
                    "Select Color", "Cancel", "Ok", colors);
                switch (selectedColor)
                {
                    case "red":
                        this.BackgroundColor = Color.Red;
                        break;
                    case "blue":
                        this.BackgroundColor = Color.Blue;
                        break;
                    case "black":
                        this.BackgroundColor = Color.Black;
                        break;
                    case "white":
                        this.BackgroundColor = Color.White;
                        break;
                    case "yellow":
                        this.BackgroundColor = Color.Yellow;
                        break;
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    btnDisplayAction
                }
            };
        }
    }
}