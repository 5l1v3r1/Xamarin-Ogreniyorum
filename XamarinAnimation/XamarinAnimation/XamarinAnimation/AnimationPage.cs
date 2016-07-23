using Xamarin.Forms;

namespace XamarinAnimation
{
    public class AnimationPage : ContentPage
    {
        public AnimationPage()
        {
            this.BackgroundColor = Color.White;
            
            RelativeLayout layout = new RelativeLayout();

            Image cc = new Image
            {
                Source = "visa.png",
                HorizontalOptions = LayoutOptions.Center
            };

            cc.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async (t) =>
                {
                    await DisplayAlert("Title", "Message", "OK");
                    //await cc.ScaleTo(0.95, 100, Easing.CubicOut);
                    //await cc.ScaleTo(1, 50, Easing.CubicIn);
                    //await cc.LayoutTo(new Rectangle(0, 150, cc.Width, cc.Height), 1250, Easing.SpringIn);
                    //await cc.RotateYTo(Device.OnPlatform(179, 180, 180), 1250, Easing.BounceIn);
                })
            });

            layout.Children.Add(cc, Constraint.Constant(0),
                Constraint.RelativeToParent((parent =>
                {
                    return parent.Height - 50;
                })),
                Constraint.RelativeToParent((parent =>
                {
                    return parent.Width;
                }))
            );

            Content = layout;
        }
    }
}