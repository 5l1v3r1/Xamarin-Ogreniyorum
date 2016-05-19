using RendererOrnek.CustomControls;
using Xamarin.Forms;

namespace RendererOrnek.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Entry myEntry = new Entry();

            MyCustomEntry customEntry = new MyCustomEntry();

            StackLayout myLayout = new StackLayout();

            myLayout.Children.Add(myEntry);
            myLayout.Children.Add(customEntry);

            Content = myLayout;
        }
    }
}