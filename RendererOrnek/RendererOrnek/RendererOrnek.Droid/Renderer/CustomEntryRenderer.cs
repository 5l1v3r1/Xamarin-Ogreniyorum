using RendererOrnek.CustomControls;
using RendererOrnek.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(CustomEntryRenderer))]
namespace RendererOrnek.Droid.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.White);
                Control.SetTextColor(Android.Graphics.Color.Blue);

                Control.Touch += Control_Touch;
            }
        }

        private void Control_Touch(object sender, TouchEventArgs e)
        {
            Control.Text = "Microsoft Türkiye! (Android)";
        }
    }
}