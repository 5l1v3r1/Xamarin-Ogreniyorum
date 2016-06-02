
using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Toasts;

namespace XamarinToast.Droid
{
    [Activity (Label = "XamarinToast", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            Xamarin.Forms.DependencyService.Register<ToastNotificatorImplementation>();
            ToastNotificatorImplementation.Init(this);
            /*
             Android için Activity içerisinde register gerekmektedir.
             Bu yüzden "this" ile o an açık olan Activity'i işaret etmiş oluyoruz.
             */

            LoadApplication (new XamarinToast.App ());
		}
	}
}

