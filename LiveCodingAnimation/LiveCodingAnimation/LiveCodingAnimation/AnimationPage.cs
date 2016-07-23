using Xamarin.Forms;

namespace LiveCodingAnimation
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
                    bool isOK = await DisplayAlert("Animasyon", "Calışsın mı?",
                        "OK", "CANCEL");
                    if (isOK)
                    {
                        await cc.ScaleTo(0.95, 100, Easing.CubicOut);
                        await cc.ScaleTo(1, 50, Easing.CubicIn);
                        await cc.LayoutTo(new Rectangle(0, 150,
                            cc.Width, cc.Height), 1250, Easing.SpringIn);
                        await cc.RotateYTo(180, 1250, Easing.Linear);
                        await cc.FadeTo(.5, 1000, Easing.BounceOut);
                        await cc.TranslateTo((cc.Width / 2), (cc.Height / 2),
                            500, Easing.SinIn);
                    }
                })
            });

            layout.Children.Add(cc, Constraint.Constant(0),
                Constraint.RelativeToParent((parent =>
                {
                    return parent.Height - 50;
                })), Constraint.RelativeToParent((parent =>
                {
                    return parent.Width;
                })));

            Content = layout;
        }
    }
}