using RendererOrnek.CustomControls;
using RendererOrnek.WinPhone.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(CustomEntryRenderer))]
namespace RendererOrnek.WinPhone.Renderer
{
    //yigit.ozaksut@xamarintr.com
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.FontStyle = Windows.UI.Text.FontStyle.Italic;
                Control.PlaceholderText = "XamarinTR.com";

                Control.GotFocus += Control_GotFocus;
            }
        }

        private void Control_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Control.Text = "Microsoft Xamarin!";
        }
    }
}